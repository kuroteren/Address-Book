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
    public partial class ViewContact : Form
    {
        private DB DBConnector = new DB();
        private int CurrentContactID = -1;
        public ViewContact()
        {
            InitializeComponent();
        }
        public ViewContact(int ContactID)
        {
            InitializeComponent();
            CurrentContactID = ContactID;
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            //Create contact to pass to database method.
            var newContact = new Contact(txt_FirstName.Text, txt_LastName.Text, txt_HomePhone.Text, txt_CellPhone.Text, 
                txt_WorkPhone.Text, txt_Email.Text, txt_Address.Text, txt_Relationship.Text, chk_favorite.Checked, chk_Secure.Checked);

            //Test to see if the user is editing an existing contact or creating a new one.
            if (CurrentContactID == -1)
            {
                var retDict = new Dictionary<int, Contact>();
                retDict.Add(-1, newContact);
                if(DBConnector.addDB(retDict))
                {
                    System.Windows.Forms.MessageBox.Show("Contact Added");
                }
                else
                {
                    System.Windows.Forms.MessageBox.Show("Add Failed, please close the application and try again.");
                }
            }
            else
            {
                var retDict = new Dictionary<int, Contact>();
                retDict.Add(CurrentContactID, newContact);
                if(DBConnector.updateDB(retDict))
                {
                    System.Windows.Forms.MessageBox.Show("Contact Saved");
                }
                else
                {
                    System.Windows.Forms.MessageBox.Show("Edit Failed, please close the application and try again.");
                }
            }
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            //TODO: Display confirmation box.
            if(DBConnector.deleteDB(CurrentContactID))
            {
                System.Windows.Forms.MessageBox.Show("Contact Deleted");
                this.Close();
            }
            else
            {
                System.Windows.Forms.MessageBox.Show("Delete Failed, please close the application and try again.");
            }
        }

        private void Btn_Home_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ViewContact_Load(object sender, EventArgs e)
        {
            if(CurrentContactID != -1)
            {

                //TODO Populate contact info.
                var currentContact = new Contact(CurrentContactID);

                if (currentContact.Secured)
                {
                    string input = Microsoft.VisualBasic.Interaction.InputBox("You must enter a password to view this contact.", "Security");
                    string password = "";

                    //Now Works!
                    Crypter cryptic = new Crypter();
                    string path = "SaveData/Settings.txt";
                    if (File.Exists(path))
                    {
                        List<string> saves = new List<string>();
                        string save;


                        var reader = new StreamReader(File.OpenRead(path));
                        while (!reader.EndOfStream)
                        {
                            save = reader.ReadLine();
                            saves.Add(cryptic.Decrypt(save));

                            foreach (string line in saves)
                            {
                                var splat = line.Split('|');
                                if (splat.Count() == 2)
                                {
                                    //Load worked
                                    password = splat[1];
                                }
                                else
                                {
                                    //Failed
                                }
                            }
                        }
                    }
                    if(input != password)
                    {
                        System.Windows.Forms.MessageBox.Show("Password was entered incorrectly, returning to main menu.");
                        this.Close();
                    }
                }

                txt_FirstName.Text = currentContact.FirstName;
                txt_LastName.Text = currentContact.LastName;
                txt_HomePhone.Text = currentContact.HomePhone;
                txt_CellPhone.Text = currentContact.CellPhone;
                txt_WorkPhone.Text = currentContact.WorkPhone;
                txt_Email.Text = currentContact.Email;
                txt_Address.Text = currentContact.Address;
                txt_Relationship.Text = currentContact.Relation;
                chk_favorite.Checked = currentContact.Favorite;
                chk_Secure.Checked = currentContact.Secured;
            }
            else
            {
                txt_FirstName.Text = "First";
                txt_LastName.Text = "Last";
            }
        }

        private void Txt_FirstName_Enter(object sender, EventArgs e)
        {
            if (txt_FirstName.Text == "First")
            {
                txt_FirstName.Text = "";
            }
        }

        private void Txt_FirstName_Leave(object sender, EventArgs e)
        {
            if (txt_FirstName.Text == "")
            {
                txt_FirstName.Text = "First";
            }
        }
        private void Txt_LastName_Enter(object sender, EventArgs e)
        {
            if (txt_LastName.Text == "Last")
            {
                txt_LastName.Text = "";
            }
        }

        private void Txt_LastName_Leave(object sender, EventArgs e)
        {
            if (txt_LastName.Text == "")
            {
                txt_LastName.Text = "Last";
            }
        }
    }
}
