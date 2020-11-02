using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace TransTool
{
    public partial class FormLogin : Form
    {
        private Connection connection = new Connection();
        private RememberMe rememberMe = new RememberMe();
        private FormRegister formRegister;
        private bool register_isLoad;
        public FormLogin(bool register_isLoad)
        {
            InitializeComponent();
            this.register_isLoad = register_isLoad;
        }

        private void button_submit_Click(object sender, EventArgs e)
        {
            int result_login = connection.LoginIsValid(textBox_email.Text, textBox_password.Text);
            switch (result_login)
            {
                case 2:
                    MessageBox.Show("Connexion Réussie!");
                    break;
                case 1:
                    MessageBox.Show("Erreur de mot de passe ou d'email.");
                    break;
                case 0:
                    MessageBox.Show("Echec lors de la connexion à la base de donnée.");
                    break;
            }

            if (checkBox_remember.Checked)
            {
                rememberMe.User_email = textBox_email.Text;
                rememberMe.User_password = textBox_password.Text;
                //Create or modify if already exist.
                rememberMe.CreateFile_JSON();  
            }
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {
            if (register_isLoad == false)
            {
                string[] userInfo = rememberMe.ReadInFile();
                if (userInfo[0] != null)
                {
                    int result_login = connection.LoginIsValid(userInfo[0], userInfo[1]);
                    switch (result_login)
                    {
                        case 2:
                            MessageBox.Show("Connexion Réussie!");
                            break;
                        case 1:
                            MessageBox.Show("Erreur de mot de passe ou d'email.");
                            this.Show();
                            break;
                        case 0:
                            MessageBox.Show("Echec lors de la connexion à la base de donnée.");
                            this.Show();
                            break;
                    }
                }
            }
        }

        private void linkLabel_login_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            formRegister = new FormRegister(true);
            formRegister.Visible = true;
            this.Visible = false;

        }

        private void FormLogin_FormClosed(object sender, FormClosedEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }
    }
}
