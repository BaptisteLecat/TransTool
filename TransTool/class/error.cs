using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading.Tasks;

namespace TransTool
{
    class Error
    {
        private string error_code;
        private string error_source;
        private string error_message;
        private Log log;

        public Error(string error_code)
        {
            this.error_code = error_code;
            DisplayError();
        }

        public Error(string error_source, string error_message, Log log)
        {
            this.error_source = error_source;
            this.error_message = error_message;
            this.log = new Log();
            DisplayError();
        }

        public void DisplayError()
        {

            switch (this.error_code)
            {
                case "email_alreadyExist":
                    MessageBox.Show("Cet email est déjà utilisé.", "Erreur Email", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    break;

                case "email_format":
                    MessageBox.Show("Le format de l'email est incorrect.", "Erreur Email", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    break;

                default:
                    MessageBox.Show("Une erreur est survenue.\nConsultez les logs pour en savoir plus.", this.error_source, MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                    this.log.Type_error = this.error_source;
                    this.log.Error_content = this.error_message;
                    this.log.WriteInFile();
                    break;
            }
        }
    }
}
