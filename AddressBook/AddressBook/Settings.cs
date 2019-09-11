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
    public partial class frm_Settings : Form
    {
        public frm_Settings()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Button to close this form and return to the previous.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Home_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }

        /// <summary>
        /// Button that saves user settings to encrypted file.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Save_Click(object sender, EventArgs e)
        {
            string order;
            if(chk_First.Checked)
            {
                order = "First";
            }
            else
            {
                order = "Last";
            }
            string password = txt_Password.Text;

            System.IO.Directory.CreateDirectory("SaveData/");
            try
            {
                Crypter cryptic = new Crypter();
                string path = "SaveData/Settings.txt";
                
                string saveData = order + "|" + password;

                string saveDataEncrypted = string.Empty;
                saveDataEncrypted = cryptic.Encrypt(saveData);

                File.WriteAllText(path, saveDataEncrypted);

                System.Windows.Forms.MessageBox.Show("Settings Saved.");
            }
            catch (Exception ex)
            {
                System.IO.Directory.CreateDirectory("LogFiles/");
                string logTitle = "Log instance from: " + DateTime.Now.Month + '/' + DateTime.Now.Day + '/' + DateTime.Now.Year + " - " + DateTime.Now.Hour + ":" + DateTime.Now.Minute;
                string path = "LogFiles/errorLog.txt";
                using (StreamWriter sw = File.AppendText(path))
                {
                    sw.WriteLine(logTitle + Environment.NewLine + ex.Message + Environment.NewLine + "Stack Trace:" + Environment.NewLine + ex.StackTrace + Environment.NewLine);
                }

                System.Windows.Forms.MessageBox.Show("Save could not be Completed, error notes saved to log file.");
            }

        }

        /// <summary>
        /// Function to ensure only one checkbox is checked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void chk_Last_CheckedChanged(object sender, EventArgs e)
        {
            if(chk_Last.Checked)
            {
                chk_First.Checked = false;
            }
        }

        /// <summary>
        /// Function to ensure only one checkbox is checked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void chk_First_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_First.Checked)
            {
                chk_Last.Checked = false;
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

        /// <summary>
        /// Function to load the form, loads the settings to populate. Requires user enter their password so that they cannot change a password without knowing it.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frm_Settings_Load(object sender, EventArgs e)
        {
            var splat = loadSettings();

            if (splat[0] == "First")
            {
                chk_First.Checked = true;
            }
            else
            {
                chk_Last.Checked = true;
            }

            txt_Password.Text = splat[1];

            string input = Microsoft.VisualBasic.Interaction.InputBox("You must first confirm your old password. If this is the first execution leave this field blank.", "Security");
            string password = splat[1];


            if (input != password)
            {
                System.Windows.Forms.MessageBox.Show("Password was entered incorrectly, returning to Main Menu.");
                this.Close();
            }
        }

        private void txt_Password_TextChanged(object sender, EventArgs e)
        {
        }
    }
    
}
