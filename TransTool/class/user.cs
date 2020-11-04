using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace TransTool
{
    class User
    {
        private int user_id;
        private string user_email;
        private string user_password;
        private DateTime user_dateCreation;
        //lIST DE TRANSFERT ET LIST D'amis.

        public User(string email, string password)
        {
            this.user_email = email;
            this.user_password = ComputeSha256Hash(password);
        }

        public string RegisterMe()

        public int User_id { get => user_id; set => user_id = value; }
        public string User_email { get => user_email; set => user_email = value; }
        public string User_password { get => user_password; set => user_password = value; }
        public DateTime User_dateCreation { get => user_dateCreation; set => user_dateCreation = value; }

        private string ComputeSha256Hash(string rawData)
        {
            // Create a SHA256   
            using (SHA256 sha256Hash = SHA256.Create())
            {
                // ComputeHash - returns byte array  
                byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(rawData));

                // Convert byte array to a string   
                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < bytes.Length; i++)
                {
                    builder.Append(bytes[i].ToString("x2"));
                }
                return builder.ToString();
            }
        }
    }
}
