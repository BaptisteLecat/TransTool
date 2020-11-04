using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TransTool
{
    public class Log
    {
        private DateTime date_time;
        private string folder_path;
        private string type_error;
        private string error_content;
        private string complete_filePath;

        private StreamWriter theFile;

        public Log()
        {
            this.date_time = DateTime.UtcNow;
            this.folder_path = Directory.GetCurrentDirectory();
            this.type_error = "";
            this.error_content = "";
            this.complete_filePath = "";

            CreateFolder();
        }

        private bool FolderExist(string folder_path)
        {
            bool flag = false;
            if (Directory.Exists(folder_path))
            {
                flag = true;
            }

            return flag;
        }

        private bool FileExist(string file_path)
        {
            bool flag = false;
            if (File.Exists(file_path))
            {
                flag = true;
            }

            return flag;
        }

        private void CreateFolder()
        {
            string newfolder_path = this.folder_path + "\\log";
            if(FolderExist(newfolder_path) == false)
            {
                Directory.CreateDirectory(newfolder_path);
            }

            this.folder_path = newfolder_path;
        }

        private void CreateLogFile()
        {
            string filename = this.date_time.Year + "-" + this.date_time.Month + "-" + this.date_time.Day + "-" + this.date_time.Hour + "-" + this.date_time.Minute + "-" + this.date_time.Second;
            this.complete_filePath = this.folder_path + "\\" + filename + ".log";
            if(FileExist(this.complete_filePath) == false)
            {
                this.theFile = new StreamWriter(this.complete_filePath);
                theFile.Close();
            }
        }

        public void WriteInFile()
        {
            CreateLogFile();
            DateTime datetime_log = DateTime.UtcNow;
            string log = "[" + datetime_log + "] - " + "[" + this.type_error + "] " + this.error_content;
            using (this.theFile = new StreamWriter(this.complete_filePath, true))
            {
                this.theFile.WriteLine(log);
            }
        }
        
           

        public DateTime Date_time { get => date_time; set => date_time = value; }
        public string Type_error { get => type_error; set => type_error = value; }
        public string Error_content { get => error_content; set => error_content = value; }
        public string Folder_path { get => folder_path; set => folder_path = value; }
    }
}
