using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TransTool
{
    public partial class FormRegister : Form
    {
        private FormLogin formLogin;
        private Connection connection = new Connection();
        private bool login_isLoad = false;
        public FormRegister(bool login_isLoad)
        {
            InitializeComponent();
            this.login_isLoad = login_isLoad;
        }

        private void linkLabel_login_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            formLogin = new FormLogin(true);
            formLogin.Visible = true;
            this.Visible = false;
        }

        private void FormRegister_FormClosed(object sender, FormClosedEventArgs e)
        {
            System.Windows.Forms.Application.Exit();  
        }

        private void button_submit_Click(object sender, EventArgs e)
        {
            if(textBox_email.Text != "" && textBox_password.Text != "")
            {
                connection.RegisterIsValid(textBox_email.Text, textBox_password.Text);
            }
        }
    }
}
