using System;
using System.Collections.Generic;
using System.Data.SQLite;


namespace AddressBook
{
    class DB
    {
        String dbConnection;

        public DB()
        {
            dbConnection = "Data Source=addbk.s3db";
        }

        /*
        Database constructor
        Incase the program is being started for the first time
        and no db exists on local device.
        */
        public bool createDB()
        {
            SQLiteConnection.CreateFile(this.dbConnection);

            SQLiteConnection dbConnection = new SQLiteConnection(this.dbConnection + ";Version=3;");
            dbConnection.Open();

            String sql = "CREATE TABLE contacts (ID INTEGER NOT NULL AUTOINCREMENT, firstName varchar(20), lastName varchar(20), homePhone varchar(10), workPhone varchar(10), cellPhone varchar(10), email varchar(30), address varchar(50), relation varchar(20), favorite int, secure int)";

            SQLiteCommand cmd = new SQLiteCommand(sql, dbConnection);

            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception)
            {
                return false;
            }

            dbConnection.Close();

            return true;
        }

        /*
        Dictionary variable insert
        Most efficient insert function
        */
        public bool addDB(Dictionary<int, Contact> data)
        {
            SQLiteConnection dbConnection = new SQLiteConnection(this.dbConnection + ";Version=3;");
            dbConnection.Open();

            foreach (KeyValuePair<int, Contact> val in data)
            {
                String sql = String.Format("INSERT INTO contacts (firstName, lastName, homePhone, workPhone, cellPhone, email, address, relation, favorite, secure) VALUES ('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}')", val.Value.FirstName, val.Value.LastName,
                    val.Value.HomePhone, val.Value.WorkPhone, val.Value.CellPhone, val.Value.Email, val.Value.Address, val.Value.Relation, b2i(val.Value.Favorite), b2i(val.Value.Secured));

                SQLiteCommand cmd = new SQLiteCommand(sql, dbConnection);

                try
                {
                    cmd.ExecuteNonQuery();
                }
                catch (Exception)
                {
                    return false;
                }
            }

            dbConnection.Close();

            return true;
        }

        /*
        Basic query function
        Retrieves contact's First and Last names
        then puts them into a Dictionary with:
        Key = first name
        value = last name
        For main menu display
        */
        public Dictionary<int, Contact> queryDB()
        {
            Dictionary<int, Contact> rtn = new Dictionary<int, Contact>();
            Contact c;
            SQLiteDataReader reader;

            SQLiteConnection dbConnection = new SQLiteConnection(this.dbConnection + ";Version=3;");
            dbConnection.Open();

            String sql = "SELECT * FROM contacts";

            SQLiteCommand cmd = new SQLiteCommand(sql, dbConnection);

            using (reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    c = new Contact(reader.GetString(reader.GetOrdinal("firstName")),
                        reader.GetString(reader.GetOrdinal("lastName")),
                        reader.GetString(reader.GetOrdinal("homePhone")),
                        reader.GetString(reader.GetOrdinal("cellPhone")),
                        reader.GetString(reader.GetOrdinal("workPhone")),
                        reader.GetString(reader.GetOrdinal("email")),
                        reader.GetString(reader.GetOrdinal("address")),
                        reader.GetString(reader.GetOrdinal("relation")),
                        i2b(reader.GetInt16(reader.GetOrdinal("favorite"))),
                        i2b(reader.GetInt16(reader.GetOrdinal("secure")))
                        );

                    rtn.Add(reader.GetInt32(reader.GetOrdinal("ID")), c);
                }
            }

            dbConnection.Close();

            return rtn;
        }

        /*
        Query database for Favorites
        Usage: query using Boolean value as input
        */
        public Dictionary<int, Contact> queryDB(Boolean favorite)
        {
            Dictionary<int, Contact> rtn = new Dictionary<int, Contact>();
            Contact c;
            SQLiteDataReader reader;

            SQLiteConnection dbConnection = new SQLiteConnection(this.dbConnection + ";Version=3;");
            dbConnection.Open();

            String sql = String.Format("SELECT * FROM contacts WHERE favorite='{0}'", b2i(favorite));

            SQLiteCommand cmd = new SQLiteCommand(sql, dbConnection);

            using (reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    c = new Contact(reader.GetString(reader.GetOrdinal("firstName")),
                        reader.GetString(reader.GetOrdinal("lastName")),
                        reader.GetString(reader.GetOrdinal("homePhone")),
                        reader.GetString(reader.GetOrdinal("cellPhone")),
                        reader.GetString(reader.GetOrdinal("workPhone")),
                        reader.GetString(reader.GetOrdinal("email")),
                        reader.GetString(reader.GetOrdinal("address")),
                        reader.GetString(reader.GetOrdinal("relation")),
                        i2b(reader.GetInt16(reader.GetOrdinal("favorite"))),
                        i2b(reader.GetInt16(reader.GetOrdinal("secure")))
                        );

                    rtn.Add(reader.GetInt32(reader.GetOrdinal("ID")), c);
                }
            }

            dbConnection.Close();

            return rtn;
        }

        /*
        Search Query based on First Name Search
        Argument: Dictionary
        Return: Dictionary of raw data of query
        */
        public Dictionary<int, Contact> queryDB(Dictionary<String, String> e)
        {
            String column = "", value = "";
            Contact c;

            foreach (KeyValuePair<String, String> val in e)
            {
                column = String.Format("{0}", val.Key.ToString());
                value = String.Format("{0}", val.Value);
            }

            Dictionary<int, Contact> rtn = new Dictionary<int, Contact>();
            SQLiteDataReader reader;

            SQLiteConnection dbConnection = new SQLiteConnection(this.dbConnection + ";Version=3;");
            dbConnection.Open();

            String sql = String.Format("SELECT * FROM contacts WHERE {0}='{1}'", column, value);

            SQLiteCommand cmd = new SQLiteCommand(sql, dbConnection);

            using (reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    c = new Contact(reader.GetString(reader.GetOrdinal("firstName")),
                        reader.GetString(reader.GetOrdinal("lastName")),
                        reader.GetString(reader.GetOrdinal("homePhone")),
                        reader.GetString(reader.GetOrdinal("cellPhone")),
                        reader.GetString(reader.GetOrdinal("workPhone")),
                        reader.GetString(reader.GetOrdinal("email")),
                        reader.GetString(reader.GetOrdinal("address")),
                        reader.GetString(reader.GetOrdinal("relation")),
                        i2b(reader.GetInt16(reader.GetOrdinal("favorite"))),
                        i2b(reader.GetInt16(reader.GetOrdinal("secure")))
                        );

                    rtn.Add(reader.GetInt32(reader.GetOrdinal("ID")), c);
                }
            }

            dbConnection.Close();

            return rtn;
        }

        public Dictionary<int, Contact> queryDB(int id)
        {
            Contact c;
            Dictionary<int, Contact> rtn = new Dictionary<int, Contact>();
            SQLiteDataReader reader;

            SQLiteConnection dbConnection = new SQLiteConnection(this.dbConnection + ";Version=3;");
            dbConnection.Open();

            String sql = String.Format("SELECT * FROM contacts WHERE ID='{0}'", id);

            SQLiteCommand cmd = new SQLiteCommand(sql, dbConnection);

            using (reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    c = new Contact(reader.GetString(reader.GetOrdinal("firstName")),
                        reader.GetString(reader.GetOrdinal("lastName")),
                        reader.GetString(reader.GetOrdinal("homePhone")),
                        reader.GetString(reader.GetOrdinal("cellPhone")),
                        reader.GetString(reader.GetOrdinal("workPhone")),
                        reader.GetString(reader.GetOrdinal("email")),
                        reader.GetString(reader.GetOrdinal("address")),
                        reader.GetString(reader.GetOrdinal("relation")),
                        i2b(reader.GetInt16(reader.GetOrdinal("favorite"))),
                        i2b(reader.GetInt16(reader.GetOrdinal("secure")))
                        );

                    rtn.Add(reader.GetInt32(reader.GetOrdinal("ID")), c);
                }
            }

            dbConnection.Close();

            return rtn;
        }

        /*
        Delete Function
        Two string argument
        safety measure.
        */
        public Boolean deleteDB(String col, String val)
        {
            SQLiteConnection dbConnection = new SQLiteConnection(this.dbConnection + ";Version=3;");
            dbConnection.Open();

            String sql = String.Format("DELETE FROM contacts WHERE {0}='{1}'", col, val);

            SQLiteCommand cmd = new SQLiteCommand(sql, dbConnection);

            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception)
            {
                return false;
            }

            dbConnection.Close();

            return true;
        }

        /*
        Delete from DB
        Allows selection of deletion to be any item
        */
        public Boolean deleteDB(Dictionary<String, String> opt)
        {
            String column = "", value = "";

            SQLiteConnection dbConnection = new SQLiteConnection(this.dbConnection + ";Version=3;");
            dbConnection.Open();

            foreach (KeyValuePair<String, String> val in opt)
            {
                column = String.Format("{0}", val.Key.ToString());
                value = String.Format("{0}", val.Value);
            }

            String sql = String.Format("DELETE FROM contacts WHERE {0}='{1}'", column, value);

            SQLiteCommand cmd = new SQLiteCommand(sql, dbConnection);

            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception)
            {
                return false;
            }

            dbConnection.Close();

            return true;
        }

        /*
        Delete by ID
        */
        public Boolean deleteDB(int id)
        {
            SQLiteConnection dbConnection = new SQLiteConnection(this.dbConnection + ";Version=3;");
            dbConnection.Open();

            String sql = String.Format("DELETE FROM contacts WHERE ID='{0}'", id);

            SQLiteCommand cmd = new SQLiteCommand(sql, dbConnection);

            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception)
            {
                return false;
            }

            dbConnection.Close();

            return true;
        }

        /*
        Update DB
        Updates contact with provided Contact. Multiple contact update functionality.
        */

        public Boolean updateDB(Dictionary<int, Contact> e)
        {
            SQLiteConnection dbConnection = new SQLiteConnection(this.dbConnection + ";Version=3;");
            dbConnection.Open();

            foreach (KeyValuePair<int, Contact> val in e)
            {
                String sql = String.Format("UPDATE contacts SET firstname='{0}', lastName='{1}', homePhone='{2}', workPhone='{3}', cellPhone='{4}', email='{5}', address='{6}', relation='{7}', favorite='{8}', secure='{9}' WHERE ID='{10}'", val.Value.FirstName, val.Value.LastName,
                    val.Value.HomePhone, val.Value.WorkPhone, val.Value.CellPhone, val.Value.Email, val.Value.Address, val.Value.Relation, b2i(val.Value.Favorite), b2i(val.Value.Secured), val.Key);

                SQLiteCommand cmd = new SQLiteCommand(sql, dbConnection);

                try
                {
                    cmd.ExecuteNonQuery();
                }
                catch (Exception)
                {
                    return false;
                }
            }

            dbConnection.Close();

            return true;
        }

        /*
        Sort Functions
        */

        /*
        Sort by First Name Alphabetical
        */
        public Dictionary<int, Contact> sortFirst()
        {
            Contact c;
            Dictionary<int, Contact> rtn = new Dictionary<int, Contact>();
            SQLiteDataReader reader;

            SQLiteConnection dbConnection = new SQLiteConnection(this.dbConnection + ";Version=3;");
            dbConnection.Open();

            String sql = String.Format("SELECT * FROM contacts ORDER BY firstName ASC");

            SQLiteCommand cmd = new SQLiteCommand(sql, dbConnection);

            using (reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    c = new Contact(reader.GetString(reader.GetOrdinal("firstName")),
                        reader.GetString(reader.GetOrdinal("lastName")),
                        reader.GetString(reader.GetOrdinal("homePhone")),
                        reader.GetString(reader.GetOrdinal("cellPhone")),
                        reader.GetString(reader.GetOrdinal("workPhone")),
                        reader.GetString(reader.GetOrdinal("email")),
                        reader.GetString(reader.GetOrdinal("address")),
                        reader.GetString(reader.GetOrdinal("relation")),
                        i2b(reader.GetInt16(reader.GetOrdinal("favorite"))),
                        i2b(reader.GetInt16(reader.GetOrdinal("secure")))
                        );

                    rtn.Add(reader.GetInt32(reader.GetOrdinal("ID")), c);
                }
            }

            dbConnection.Close();

            return rtn;
        }

        /*
        Sort by First Name Reverse Alphabetical
        */
        public Dictionary<int, Contact> sortFirstRev()
        {
            Contact c;
            Dictionary<int, Contact> rtn = new Dictionary<int, Contact>();
            SQLiteDataReader reader;

            SQLiteConnection dbConnection = new SQLiteConnection(this.dbConnection + ";Version=3;");
            dbConnection.Open();

            String sql = String.Format("SELECT * FROM contacts ORDER BY firstName DESC");

            SQLiteCommand cmd = new SQLiteCommand(sql, dbConnection);

            using (reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    c = new Contact(reader.GetString(reader.GetOrdinal("firstName")),
                        reader.GetString(reader.GetOrdinal("lastName")),
                        reader.GetString(reader.GetOrdinal("homePhone")),
                        reader.GetString(reader.GetOrdinal("cellPhone")),
                        reader.GetString(reader.GetOrdinal("workPhone")),
                        reader.GetString(reader.GetOrdinal("email")),
                        reader.GetString(reader.GetOrdinal("address")),
                        reader.GetString(reader.GetOrdinal("relation")),
                        i2b(reader.GetInt16(reader.GetOrdinal("favorite"))),
                        i2b(reader.GetInt16(reader.GetOrdinal("secure")))
                        );

                    rtn.Add(reader.GetInt32(reader.GetOrdinal("ID")), c);
                }
            }

            dbConnection.Close();

            return rtn;
        }

        /*
        Sort by Last Name Alphabetical
        */
        public Dictionary<int, Contact> sortLast()
        {
            Contact c;
            Dictionary<int, Contact> rtn = new Dictionary<int, Contact>();
            SQLiteDataReader reader;

            SQLiteConnection dbConnection = new SQLiteConnection(this.dbConnection + ";Version=3;");
            dbConnection.Open();

            String sql = String.Format("SELECT * FROM contacts ORDER BY lastName ASC");

            SQLiteCommand cmd = new SQLiteCommand(sql, dbConnection);

            using (reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    c = new Contact(reader.GetString(reader.GetOrdinal("firstName")),
                        reader.GetString(reader.GetOrdinal("lastName")),
                        reader.GetString(reader.GetOrdinal("homePhone")),
                        reader.GetString(reader.GetOrdinal("cellPhone")),
                        reader.GetString(reader.GetOrdinal("workPhone")),
                        reader.GetString(reader.GetOrdinal("email")),
                        reader.GetString(reader.GetOrdinal("address")),
                        reader.GetString(reader.GetOrdinal("relation")),
                        i2b(reader.GetInt16(reader.GetOrdinal("favorite"))),
                        i2b(reader.GetInt16(reader.GetOrdinal("secure")))
                        );

                    rtn.Add(reader.GetInt32(reader.GetOrdinal("ID")), c);
                }
            }

            dbConnection.Close();

            return rtn;
        }

        /*
        Sort by Last Name Reverse Alphabetical
        */
        public Dictionary<int, Contact> sortLastRev()
        {
            Contact c;
            Dictionary<int, Contact> rtn = new Dictionary<int, Contact>();
            SQLiteDataReader reader;

            SQLiteConnection dbConnection = new SQLiteConnection(this.dbConnection + ";Version=3;");
            dbConnection.Open();

            String sql = String.Format("SELECT * FROM contacts ORDER BY lastName DESC");

            SQLiteCommand cmd = new SQLiteCommand(sql, dbConnection);

            using (reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    c = new Contact(reader.GetString(reader.GetOrdinal("firstName")),
                        reader.GetString(reader.GetOrdinal("lastName")),
                        reader.GetString(reader.GetOrdinal("homePhone")),
                        reader.GetString(reader.GetOrdinal("cellPhone")),
                        reader.GetString(reader.GetOrdinal("workPhone")),
                        reader.GetString(reader.GetOrdinal("email")),
                        reader.GetString(reader.GetOrdinal("address")),
                        reader.GetString(reader.GetOrdinal("relation")),
                        i2b(reader.GetInt16(reader.GetOrdinal("favorite"))),
                        i2b(reader.GetInt16(reader.GetOrdinal("secure")))
                        );

                    rtn.Add(reader.GetInt32(reader.GetOrdinal("ID")), c);
                }
            }

            dbConnection.Close();

            return rtn;
        }

        /*
        Sort by Favorite status, with Alphabetical Order.
        */
        public Dictionary<int, Contact> sortFav()
        {
            Contact c;
            Dictionary<int, Contact> rtn = new Dictionary<int, Contact>();
            SQLiteDataReader reader;

            SQLiteConnection dbConnection = new SQLiteConnection(this.dbConnection + ";Version=3;");
            dbConnection.Open();

            String sql = String.Format("SELECT * FROM contacts ORDER BY favorite DESC, firstName ASC");

            SQLiteCommand cmd = new SQLiteCommand(sql, dbConnection);

            using (reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    c = new Contact(reader.GetString(reader.GetOrdinal("firstName")),
                        reader.GetString(reader.GetOrdinal("lastName")),
                        reader.GetString(reader.GetOrdinal("homePhone")),
                        reader.GetString(reader.GetOrdinal("cellPhone")),
                        reader.GetString(reader.GetOrdinal("workPhone")),
                        reader.GetString(reader.GetOrdinal("email")),
                        reader.GetString(reader.GetOrdinal("address")),
                        reader.GetString(reader.GetOrdinal("relation")),
                        i2b(reader.GetInt16(reader.GetOrdinal("favorite"))),
                        i2b(reader.GetInt16(reader.GetOrdinal("secure")))
                        );

                    rtn.Add(reader.GetInt32(reader.GetOrdinal("ID")), c);
                }
            }

            dbConnection.Close();

            return rtn;
        }

        /*
        Search DB functions
        */

        /*
        Starts with string search
        Returns any row where first name starts with input string
        */
        public Dictionary<int, Contact> searchFirstFront(String x)
        {
            Contact c;
            Dictionary<int, Contact> rtn = new Dictionary<int, Contact>();
            SQLiteDataReader reader;

            SQLiteConnection dbConnection = new SQLiteConnection(this.dbConnection + ";Version=3;");
            dbConnection.Open();

            String sql = String.Format("SELECT * FROM contacts WHERE firstName LIKE '{0}%'", x);

            SQLiteCommand cmd = new SQLiteCommand(sql, dbConnection);

            using (reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    c = new Contact(reader.GetString(reader.GetOrdinal("firstName")),
                        reader.GetString(reader.GetOrdinal("lastName")),
                        reader.GetString(reader.GetOrdinal("homePhone")),
                        reader.GetString(reader.GetOrdinal("cellPhone")),
                        reader.GetString(reader.GetOrdinal("workPhone")),
                        reader.GetString(reader.GetOrdinal("email")),
                        reader.GetString(reader.GetOrdinal("address")),
                        reader.GetString(reader.GetOrdinal("relation")),
                        i2b(reader.GetInt16(reader.GetOrdinal("favorite"))),
                        i2b(reader.GetInt16(reader.GetOrdinal("secure")))
                        );

                    rtn.Add(reader.GetInt32(reader.GetOrdinal("ID")), c);
                }
            }

            dbConnection.Close();

            return rtn;
        }

        /*
        Contains string search
        Returns any row where first name contains input string
        */
        public Dictionary<int, Contact> searchFirstContains(String x)
        {
            Contact c;
            Dictionary<int, Contact> rtn = new Dictionary<int, Contact>();
            SQLiteDataReader reader;

            SQLiteConnection dbConnection = new SQLiteConnection(this.dbConnection + ";Version=3;");
            dbConnection.Open();

            String sql = String.Format("SELECT * FROM contacts WHERE firstName LIKE '%{0}%'", x);

            SQLiteCommand cmd = new SQLiteCommand(sql, dbConnection);

            using (reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    c = new Contact(reader.GetString(reader.GetOrdinal("firstName")),
                        reader.GetString(reader.GetOrdinal("lastName")),
                        reader.GetString(reader.GetOrdinal("homePhone")),
                        reader.GetString(reader.GetOrdinal("cellPhone")),
                        reader.GetString(reader.GetOrdinal("workPhone")),
                        reader.GetString(reader.GetOrdinal("email")),
                        reader.GetString(reader.GetOrdinal("address")),
                        reader.GetString(reader.GetOrdinal("relation")),
                        i2b(reader.GetInt16(reader.GetOrdinal("favorite"))),
                        i2b(reader.GetInt16(reader.GetOrdinal("secure")))
                        );

                    rtn.Add(reader.GetInt32(reader.GetOrdinal("ID")), c);
                }
            }

            dbConnection.Close();

            return rtn;
        }

        /*
        Ends with string search
        Returns any row where first name ends with input string
        */
        public Dictionary<int, Contact> searchFirstEnd(String x)
        {
            Contact c;
            Dictionary<int, Contact> rtn = new Dictionary<int, Contact>();
            SQLiteDataReader reader;

            SQLiteConnection dbConnection = new SQLiteConnection(this.dbConnection + ";Version=3;");
            dbConnection.Open();

            String sql = String.Format("SELECT * FROM contacts WHERE firstName LIKE '%{0}'", x);

            SQLiteCommand cmd = new SQLiteCommand(sql, dbConnection);

            using (reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    c = new Contact(reader.GetString(reader.GetOrdinal("firstName")),
                        reader.GetString(reader.GetOrdinal("lastName")),
                        reader.GetString(reader.GetOrdinal("homePhone")),
                        reader.GetString(reader.GetOrdinal("cellPhone")),
                        reader.GetString(reader.GetOrdinal("workPhone")),
                        reader.GetString(reader.GetOrdinal("email")),
                        reader.GetString(reader.GetOrdinal("address")),
                        reader.GetString(reader.GetOrdinal("relation")),
                        i2b(reader.GetInt16(reader.GetOrdinal("favorite"))),
                        i2b(reader.GetInt16(reader.GetOrdinal("secure")))
                        );

                    rtn.Add(reader.GetInt32(reader.GetOrdinal("ID")), c);
                }
            }

            dbConnection.Close();

            return rtn;
        }

        /*
        Starts with string search
        Returns any row where last name starts with input string
        */
        public Dictionary<int, Contact> searchLastFront(String x)
        {
            Contact c;
            Dictionary<int, Contact> rtn = new Dictionary<int, Contact>();
            SQLiteDataReader reader;

            SQLiteConnection dbConnection = new SQLiteConnection(this.dbConnection + ";Version=3;");
            dbConnection.Open();

            String sql = String.Format("SELECT * FROM contacts WHERE lastName LIKE '{0}%'", x);

            SQLiteCommand cmd = new SQLiteCommand(sql, dbConnection);

            using (reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    c = new Contact(reader.GetString(reader.GetOrdinal("firstName")),
                        reader.GetString(reader.GetOrdinal("lastName")),
                        reader.GetString(reader.GetOrdinal("homePhone")),
                        reader.GetString(reader.GetOrdinal("cellPhone")),
                        reader.GetString(reader.GetOrdinal("workPhone")),
                        reader.GetString(reader.GetOrdinal("email")),
                        reader.GetString(reader.GetOrdinal("address")),
                        reader.GetString(reader.GetOrdinal("relation")),
                        i2b(reader.GetInt16(reader.GetOrdinal("favorite"))),
                        i2b(reader.GetInt16(reader.GetOrdinal("secure")))
                        );

                    rtn.Add(reader.GetInt32(reader.GetOrdinal("ID")), c);
                }
            }

            dbConnection.Close();

            return rtn;
        }

        /*
        Contains string search
        Returns any row where last name contains input string
        */
        public Dictionary<int, Contact> searchLastContains(String x)
        {
            Contact c;
            Dictionary<int, Contact> rtn = new Dictionary<int, Contact>();
            SQLiteDataReader reader;

            SQLiteConnection dbConnection = new SQLiteConnection(this.dbConnection + ";Version=3;");
            dbConnection.Open();

            String sql = String.Format("SELECT * FROM contacts WHERE lastName LIKE '%{0}%'", x);

            SQLiteCommand cmd = new SQLiteCommand(sql, dbConnection);

            using (reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    c = new Contact(reader.GetString(reader.GetOrdinal("firstName")),
                        reader.GetString(reader.GetOrdinal("lastName")),
                        reader.GetString(reader.GetOrdinal("homePhone")),
                        reader.GetString(reader.GetOrdinal("cellPhone")),
                        reader.GetString(reader.GetOrdinal("workPhone")),
                        reader.GetString(reader.GetOrdinal("email")),
                        reader.GetString(reader.GetOrdinal("address")),
                        reader.GetString(reader.GetOrdinal("relation")),
                        i2b(reader.GetInt16(reader.GetOrdinal("favorite"))),
                        i2b(reader.GetInt16(reader.GetOrdinal("secure")))
                        );

                    rtn.Add(reader.GetInt32(reader.GetOrdinal("ID")), c);
                }
            }

            dbConnection.Close();

            return rtn;
        }

        /*
        Ends with string search
        Returns any row where last name ends with input string
        */
        public Dictionary<int, Contact> searchLastEnd(String x)
        {
            Contact c;
            Dictionary<int, Contact> rtn = new Dictionary<int, Contact>();
            SQLiteDataReader reader;

            SQLiteConnection dbConnection = new SQLiteConnection(this.dbConnection + ";Version=3;");
            dbConnection.Open();

            String sql = String.Format("SELECT * FROM contacts WHERE lastName LIKE '%{0}'", x);

            SQLiteCommand cmd = new SQLiteCommand(sql, dbConnection);

            using (reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    c = new Contact(reader.GetString(reader.GetOrdinal("firstName")),
                        reader.GetString(reader.GetOrdinal("lastName")),
                        reader.GetString(reader.GetOrdinal("homePhone")),
                        reader.GetString(reader.GetOrdinal("cellPhone")),
                        reader.GetString(reader.GetOrdinal("workPhone")),
                        reader.GetString(reader.GetOrdinal("email")),
                        reader.GetString(reader.GetOrdinal("address")),
                        reader.GetString(reader.GetOrdinal("relation")),
                        i2b(reader.GetInt16(reader.GetOrdinal("favorite"))),
                        i2b(reader.GetInt16(reader.GetOrdinal("secure")))
                        );

                    rtn.Add(reader.GetInt32(reader.GetOrdinal("ID")), c);
                }
            }

            dbConnection.Close();

            return rtn;
        }

        /*
        Boolean to int converter
        Internal usage
        Meant to ease use of boolean value in SQL
       */
        int b2i(Boolean b)
        {
            if (b)
                return 1;
            else
                return 0;
        }

        Boolean i2b(int i)
        {
            if (i == 1)
                return true;
            else
                return false;
        }
    }
}
