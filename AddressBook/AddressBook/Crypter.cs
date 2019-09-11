using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook
{
    public class Crypter
    {
        private string key;
        public Crypter()
        {
            //!!!
            //IMPORTANT: KEY MUST BE 16 OR 24 CHARACTERS
            //!!!
            key = "$uP3r5EcuR3_k3Y!"; //16
        }
        public Crypter(string key)
        {
            if (key.Length == 16 || key.Length == 24) //Make sure they followed the IMPORTANT message.
            {
                this.key = key;
            }
            else
            {
                var diff = 16 - key.Length;
                if (diff > 0)
                {
                    for (int x = 0; x < diff; x++)
                    {
                        key += "5";
                    }
                }
                else
                {
                    key = key.Substring(0, 16);
                }
            }
        }
        //method to encrypt a string, returns encrypted string.
        public string Encrypt(string toEncrypt)
        {
            byte[] keyArray;
            byte[] toEncryptArray = UTF8Encoding.UTF8.GetBytes(toEncrypt);

            keyArray = UTF8Encoding.UTF8.GetBytes(key);

            TripleDESCryptoServiceProvider tdes = new TripleDESCryptoServiceProvider();
            //set the secret key for the tripleDES algorithm
            tdes.Key = keyArray;
            //mode of operation. there are other 4 modes. We choose ECB(Electronic code Book)
            tdes.Mode = CipherMode.ECB;
            //padding mode(if any extra byte added)
            tdes.Padding = PaddingMode.PKCS7;

            ICryptoTransform cTransform = tdes.CreateEncryptor();
            //transform the specified region of bytes array to resultArray
            byte[] resultArray = cTransform.TransformFinalBlock
                    (toEncryptArray, 0, toEncryptArray.Length);
            //Release resources held by TripleDes Encryptor
            tdes.Clear();
            //Return the encrypted data into unreadable string format
            return Convert.ToBase64String(resultArray, 0, resultArray.Length);
        }

        //method to decrypt a string, returns decrypted string
        public string Decrypt(string cipherString)
        {
            if ((cipherString.Length % 4) == 0 && cipherString.Length > 0)
            {

                byte[] keyArray;
                //get the byte code of the string
                byte[] toEncryptArray = Convert.FromBase64String(cipherString);

                keyArray = UTF8Encoding.UTF8.GetBytes(key);

                TripleDESCryptoServiceProvider tdes = new TripleDESCryptoServiceProvider();
                //set the secret key for the tripleDES algorithm
                tdes.Key = keyArray;
                //mode of operation. there are other 4 modes.
                //We choose ECB(Electronic code Book)

                tdes.Mode = CipherMode.ECB;
                //padding mode(if any extra byte added)
                tdes.Padding = PaddingMode.PKCS7;

                ICryptoTransform cTransform = tdes.CreateDecryptor();
                byte[] resultArray = cTransform.TransformFinalBlock
                        (toEncryptArray, 0, toEncryptArray.Length);
                //Release resources held by TripleDes Encryptor
                tdes.Clear();
                //return the Clear decrypted TEXT
                return UTF8Encoding.UTF8.GetString(resultArray);
            }
            else
            {
                return "String was not the correct length, cannot decrypt.";
            }
        }
    }
}
