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

        public Error(string error_code)
        {
            this.error_code = error_code;
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

                case "connection_unreachable":
                    MessageBox.Show("Impossible d'accéder à la base de donnée.\nConsultez les logs pour en savoir plus.", "Erreur de connection", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                    break;
            }
        }
    }
}
