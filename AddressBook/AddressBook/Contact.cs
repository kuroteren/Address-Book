using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook
{
    class Contact
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string HomePhone { get; set; }
        public string CellPhone { get; set; }
        public string WorkPhone { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public string Relation { get; set; }
        public bool Favorite { get; set; }
        public bool Secured { get; set; }

        //Default Constructor
        public Contact()
        {
            FirstName = "John";
            LastName = "Doe";
            CellPhone = "(800)876-5309";
            Email = "johndoe@hotmail.com";
            Address = "1234 Cherry Blossom Lane";
        }
        
        //Constructor to create existing contact object
        public Contact(int ID)
        {
            //use this one to lookup contacts in database
            DB DBConnector = new DB();

            var selectedContact = DBConnector.queryDB(ID);
            if(selectedContact.Count == 1)
            {
                foreach (Contact currentContact in selectedContact.Values)
                {
                    FirstName = currentContact.FirstName;
                    LastName = currentContact.LastName;
                    HomePhone = currentContact.HomePhone;
                    CellPhone = currentContact.CellPhone;
                    WorkPhone = currentContact.WorkPhone;
                    Email = currentContact.Email;
                    Address = currentContact.Address;
                    Relation = currentContact.Relation;
                    Favorite = currentContact.Favorite;
                    Secured = currentContact.Secured;
                }
            }
            else
            {
                FirstName = "John";
                LastName = "Doe";
                CellPhone = "(800)876-5309";
                Email = "johndoe@hotmail.com";
                Address = "1234 Cherry Blossom Lane";


                System.Windows.Forms.MessageBox.Show("Error: Contact Could Not Be Loaded");
            }
        }

        //Constructor to create new contact
        public Contact(string FirstName, string LastName, string HomePhone, string CellPhone, string WorkPhone, string Email, string Address,
            string Relation, bool Favorite, bool Secured)
        {
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.HomePhone = HomePhone;
            this.CellPhone = CellPhone;
            this.WorkPhone = WorkPhone;
            this.Email = Email;
            this.Address = Address;
            this.Relation = Relation;
            this.Favorite = Favorite;
            this.Secured = Secured;
        }
        

    }
}
