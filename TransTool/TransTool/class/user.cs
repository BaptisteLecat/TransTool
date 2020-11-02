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
            this.user_password = password;
        }

        public int User_id { get => user_id; set => user_id = value; }
        public string User_email { get => user_email; set => user_email = value; }
        public string User_password { get => user_password; set => user_password = value; }
        public DateTime User_dateCreation { get => user_dateCreation; set => user_dateCreation = value; }
    }
}
