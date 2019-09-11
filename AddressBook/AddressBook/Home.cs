using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AddressBook
{
    public partial class frm_Home : Form
    {
        private DB DBConnector = new DB();
        private Dictionary<String, Contact> FavoriteContacts = new Dictionary<string, Contact>();

        public frm_Home()
        {
            InitializeComponent();

            //Check if there is an existing database.
            if(!File.Exists("addbk.s3db"))
            {
                //If not database, create one.
                DBConnector.createDB();
            }
        }

        /// <summary>
        /// When settings button is clicked on the main menu, take the user to the settings page.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Settings_Click(object sender, EventArgs e)
        {
            this.Hide();
            
            using (frm_Settings frm_Settings = new frm_Settings())
                frm_Settings.ShowDialog();
            this.Show();
        }

        /// <summary>
        /// Function to load the home page, loads user settings.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frm_Home_Load(object sender, EventArgs e)
        {
            populateFav();
        }
        
        /// <summary>
        /// Button to view all contacts, launches All Contacts form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_All_Click(object sender, EventArgs e)
        {
            this.Hide();

            using (frm_AllContcats frm_AllContacts = new frm_AllContcats())
                frm_AllContacts.ShowDialog();
            this.Show();
            populateFav();
        }

        /// <summary>
        /// Button to add a contact, launches the View Contact form with a blank form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Add_Click(object sender, EventArgs e)
        {
            this.Hide();

            using (ViewContact frm_ViewContact = new ViewContact())
                frm_ViewContact.ShowDialog();
            this.Show();
            populateFav();
        }

        /// <summary>
        /// Button to view the selected favorite contact.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_View_Click(object sender, EventArgs e)
        {
            int selectedID = int.Parse(cbo_Fav.SelectedValue.ToString());
            this.Hide();

            using (ViewContact frm_ViewContact = new ViewContact(selectedID))
                frm_ViewContact.ShowDialog();
            this.Show();
        }

        private void populateFav()
        {
            var AllContacts = DBConnector.queryDB(true);

            if (AllContacts.Count > 0)
            {
                //Setup data source as: (ID, First_Last)
                var contactsDataSouce = new Dictionary<int, string>();
                foreach (int id in AllContacts.Keys)
                {
                    var name = AllContacts[id].FirstName + " " + AllContacts[id].LastName;
                    contactsDataSouce.Add(id, name);
                }
                cbo_Fav.DisplayMember = "Value";
                cbo_Fav.ValueMember = "Key";
                cbo_Fav.DataSource = new BindingSource(contactsDataSouce, null);
            }
        }
    }
}
