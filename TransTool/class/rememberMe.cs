using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json;
using System.Windows.Forms;
using Newtonsoft.Json.Linq;
using System.Globalization;
using System.Security.Cryptography;

namespace TransTool
{
    public class RememberMe
    {
        private string user_email;
        private string user_password;

        private string datetime_create;
        private string folder_path;
        private string filename;
        private string file_ext;
        private string complete_filePath;
        StreamWriter writeFile;

        public string User_email { get => user_email; set => user_email = value; }
        public string User_password { get => user_password; set => user_password = ComputeSha256Hash(value); }

        public RememberMe()
        {
            this.user_email = "";
            this.user_password = "";

            this.datetime_create = DateTime.Now.ToString();
            this.folder_path = Directory.GetCurrentDirectory();
            this.filename = "rememberMe";
            this.file_ext = ".json";
            this.complete_filePath = "";
        }

        public bool FileExist()
        {
            bool flag = false;

            this.complete_filePath = this.folder_path + "\\" + this.filename + this.file_ext;
            if (File.Exists(this.complete_filePath))
            {
                flag = true;
            }

            return flag;
        }

        public void CreateFile_JSON()
        {
            if(FileExist() == false)
            {
                this.writeFile = File.CreateText(this.complete_filePath);
                this.writeFile.Close();
            }

            WriteInFile();
        }

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

        private void WriteInFile()
        {
            RememberMe_Info rememberMe_Info = new RememberMe_Info
            {
                email = this.user_email,
                password = this.user_password,
                date = this.datetime_create
            };

            File.WriteAllText(this.complete_filePath, JsonConvert.SerializeObject(rememberMe_Info, Formatting.Indented));
        }

        public void DeleteFile()
        {
            File.Delete(this.complete_filePath);
        }

        public string[] ReadInFile()
        {
            string[] infoUser = new string[2];
            if (FileExist())
            {
                var myJsonString = File.ReadAllText(this.complete_filePath);
                var myJObject = JObject.Parse(myJsonString);
                //getting the differents user connection items.
                this.user_email = myJObject.SelectToken("email").Value<string>();
                this.user_password = myJObject.SelectToken("password").Value<string>();
                this.datetime_create = myJObject.SelectToken("date").Value<string>();
                //difference between the creation date of the remember and the date of today.
                DateTime dateReadMe = DateTime.Parse(this.datetime_create);
                DateTime dateToday = DateTime.Now;
                TimeSpan diff_date = dateToday - dateReadMe;
                double dayOfDiff = diff_date.TotalDays;
                if(dayOfDiff < 15)
                {
                    infoUser[0] = this.user_email;
                    infoUser[1] = this.user_password;
                }
                else
                {
                    DeleteFile();
                }
            }

            return infoUser;
        }

    }
}
