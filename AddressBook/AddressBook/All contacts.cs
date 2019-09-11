using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AddressBook
{
    public partial class frm_AllContcats : Form
    {
        private string[] settings;
        private DB DBConnector = new DB();
        public frm_AllContcats()
        {
            InitializeComponent();
        }

        /// <summary>
        /// //Load event for form. loads settings and populates contact list.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_Load(object sender, EventArgs e)
        {
            settings = loadSettings();
            populateContactList(); 
        }

        /// <summary>
        /// //Button to return to previous form.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Home_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Button to view a contact, launches ViewContact populated with contact information
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_View_Click(object sender, EventArgs e)
        {
            int selectedID = int.Parse(cbo_Contacts.SelectedValue.ToString());
            this.Hide();

            using (ViewContact frm_ViewContact = new ViewContact(selectedID)) 
                frm_ViewContact.ShowDialog();
            this.Show();
            populateContactList();
        }

        /// <summary>
        /// Button to filter contacts based on search. Filters to contacts where first or last name contains entered text.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Filter_Click(object sender, EventArgs e)
        {
            var filterText = txt_Filter.Text;

            if(!string.IsNullOrEmpty(filterText) && !string.IsNullOrWhiteSpace(filterText))
            {
                var AllContacts = DBConnector.queryDB();
                var filterContacts = new Dictionary<int, Contact>();
                foreach(int id in AllContacts.Keys)
                {
                    if (AllContacts[id].FirstName.ToLower().Contains(filterText.ToLower()) || AllContacts[id].LastName.ToLower().Contains(filterText.ToLower()))
                    {
                        filterContacts.Add(id, AllContacts[id]);
                    }
                }

                if (filterContacts.Count > 0)
                {
                    //Setup data source as: (ID, First_Last)
                    var contactsDataSouce = new Dictionary<int, string>();
                    foreach (int id in filterContacts.Keys)
                    {
                        var name = filterContacts[id].FirstName + " " + filterContacts[id].LastName;
                        contactsDataSouce.Add(id, name);
                    }
                    cbo_Contacts.DisplayMember = "Value";
                    cbo_Contacts.ValueMember = "Key";
                    cbo_Contacts.DataSource = new BindingSource(contactsDataSouce, null);
                }
                else
                {
                    cbo_Contacts.DisplayMember = "Value";
                    cbo_Contacts.ValueMember = "Key";
                    cbo_Contacts.DataSource = new BindingSource(new Dictionary<int, string>(), null);
                }
            }
            else
            {
                populateContactList();
            }
        }

        /// <summary>
        /// Function to populate the contact list; populates in Alphabetical order by Last or First name depending on settings. (Last is default)
        /// </summary>
        private void populateContactList()
        {

            var AllContacts = DBConnector.sortLast();

            if (settings[0] == "First")
            {
                AllContacts = DBConnector.sortFirst();
            }

            if (AllContacts.Count > 0)
            {
                //Setup data source as: (ID, First_Last)
                var contactsDataSouce = new Dictionary<int, string>();
                foreach (int id in AllContacts.Keys)
                {
                    var name = AllContacts[id].FirstName + " " + AllContacts[id].LastName;
                    contactsDataSouce.Add(id, name);
                }
                cbo_Contacts.DisplayMember = "Value";
                cbo_Contacts.ValueMember = "Key";
                cbo_Contacts.DataSource = new BindingSource(contactsDataSouce, null);
            }
        }

        /// <summary>
        /// Function to load the settings from the encrypted file.
        /// </summary>
        /// <returns>string[2] where [0] is the sort order and [1] is the user's password.</returns>
        private string[] loadSettings()
        {
            //Now Works!
            Crypter cryptic = new Crypter();
            string path = "SaveData/Settings.txt";
            if (File.Exists(path))
            {
                List<string> saves = new List<string>();
                string save;

                using (var reader = new StreamReader(File.OpenRead(path)))
                {
                    while (!reader.EndOfStream)
                    {
                        save = reader.ReadLine();
                        saves.Add(cryptic.Decrypt(save));

                        foreach (string line in saves)
                        {
                            var splat = line.Split('|');
                            if (splat.Count() == 2)
                            {
                                return splat;
                            }
                            else
                            {
                                return new string[] { "Last", "" };
                            }
                        }
                    }
                }
            }

            return new string[] { "Last", "" };
        }
    }
    
}
