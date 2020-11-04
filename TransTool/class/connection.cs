using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Text.RegularExpressions;
using System.Security.Cryptography;

namespace TransTool
{
    public class Connection
    {
        private const string db_server = "localhost";
        private const string db_database = "transtool";
        private const string db_identifiant = "root";
        private const string db_password = "";
        private MySqlConnection connection;
        private Log error_log = new Log();

        public Connection()
        {
            ConnectionState();
            
        }

        public bool ConnectionState()
        {
            int nb_error = 0;
            bool error_state = false;
            string connection_string = "server=" + db_server + ";database=" + db_database + ";uid=" + db_identifiant + ";passwd=" + db_password;

            do
            {
                nb_error++;
                try
                {
                    this.connection = new MySqlConnection(connection_string);
                    connection.Open();
                }
                catch (MySqlException e)
                {
                    error_state = true;
                }

                if(error_state == false)
                {
                    break;
                }

            } while (nb_error < 2);

            connection.Close();
            return error_state;

        }

        //error_state = 0 => error system ; error_state = 1 => error password or email ; error_state = 2 => success.
        public int LoginIsValid(string email, string password)
        {
            int error_state = 1;
            string request = "SELECT user_id FROM user WHERE user_email = @emailuser and user_password = @passworduser";

            try
            {
                connection.Open();
                MySqlCommand testlogin = new MySqlCommand(request, this.connection);
                testlogin.Parameters.AddWithValue("@emailuser", email);
                testlogin.Parameters.AddWithValue("@passworduser", ComputeSha256Hash(password));
                MySqlDataReader read_testlogin = testlogin.ExecuteReader();

                if (read_testlogin.Read())
                {
                    if (read_testlogin.HasRows)
                    {
                        //success
                        int id_user = int.Parse(read_testlogin["user_id"].ToString());
                        error_state = 2;
                    }
                }

            }catch(Exception e)
            {
                error_state = 0;
                this.error_log.Type_error = e.Source.ToString();
                this.error_log.Error_content = e.Message;
                this.error_log.WriteInFile();
            }

            connection.Close();
            return error_state;
        }

        //error_state = 0 => error system ; error_state = 1 => emailExist ; error_state = 2 => Email doesn't exist.
        private int EmailExist(string email)
        {
            int error_state = 2;

            string request = "SELECT user_email FROM user WHERE user_email = @emailuser";

            try
            {
                connection.Open();
                MySqlCommand testEmail = new MySqlCommand(request, this.connection);
                testEmail.Parameters.AddWithValue("@emailuser", email);
                MySqlDataReader read_testEmail = testEmail.ExecuteReader();

                if (read_testEmail.Read())
                {
                    if (read_testEmail.HasRows)
                    {
                        error_state = 1;
                    }
                }
            }catch(MySqlException e)
            {
                error_state = 0;
                this.error_log.Type_error = e.Source.ToString();
                this.error_log.Error_content = e.Message;
                this.error_log.WriteInFile();
            }

            connection.Close();
            return error_state;
        }

        private bool EmailFormat(string email)
        {
            bool isEmail = Regex.IsMatch(email, @"\A(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?)\Z", RegexOptions.IgnoreCase);
            return isEmail;
        }

        //error_state = 0 => error system ; error_state = 1 => emailExist ; error_state = 2 => Email doesn't exist.
        private int InsertAccount(string email, string password)
        {
            int error_state = 1;

            string request = "INSERT INTO user (user_email, user_password, user_datecreation) VALUES (@emailuser, @passworduser, @datecreationuser)";

            try
            {
                connection.Open();
                MySqlCommand insertAccount = new MySqlCommand(request, connection);
                insertAccount.Parameters.AddWithValue("@emailuser", email);
                insertAccount.Parameters.AddWithValue("passworduser", password);
                DateTime dateToday = DateTime.Now;
                insertAccount.Parameters.AddWithValue("@datecreationuser", dateToday.ToString("yyyy/MM/dd"));
                MySqlDataReader read_insertAccount = insertAccount.ExecuteReader();

                if (read_insertAccount.Read())
                {
                    if(read_insertAccount.RecordsAffected > 0)
                    {
                        error_state = 2;
                    }
                }
            }
            catch(MySqlException e)
            {
                error_state = 0;
                this.error_log.Type_error = e.Source.ToString();
                this.error_log.Error_content = e.Message;
                this.error_log.WriteInFile();
            }

            connection.Close();
            return error_state;
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

        //error_state = 0 => error system ; error_state = 1 => error ; error_state = 2 => Success Register.
        public int RegisterIsValid(string email, string password)
        {
            int error_state = 1;

            try
            {
                if (EmailFormat(email))
                {
                    if (EmailExist(email) == 2)
                    {
                        InsertAccount(email, password);
                        error_state = 2;
                    }
                    else
                    {
                        MessageBox.Show("Cet email existe déjà");
                    }
                }
                else
                {
                    MessageBox.Show("Le format de l'email n'est pas correct.");
                }
            }
            catch(Exception e)
            {
                error_state = 0;
                this.error_log.Type_error = e.Source.ToString();
                this.error_log.Error_content = e.Message;
                this.error_log.WriteInFile();
            }

            return error_state;
        }
    }
}
