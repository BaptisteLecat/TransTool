using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace TransTool
{
    partial class FormLogin
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.label_title = new System.Windows.Forms.Label();
            this.linkLabel_login = new System.Windows.Forms.LinkLabel();
            this.label_loginText = new System.Windows.Forms.Label();
            this.textBox_email = new System.Windows.Forms.TextBox();
            this.textBox_password = new System.Windows.Forms.TextBox();
            this.checkBox_remember = new System.Windows.Forms.CheckBox();
            this.label_email = new System.Windows.Forms.Label();
            this.label_password = new System.Windows.Forms.Label();
            this.button_submit = new System.Windows.Forms.Button();
            this.panel_email = new System.Windows.Forms.Panel();
            this.panel_password = new System.Windows.Forms.Panel();
            this.pictureBox_email = new System.Windows.Forms.PictureBox();
            this.pictureBox_password = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_email)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_password)).BeginInit();
            this.SuspendLayout();
            // 
            // label_title
            // 
            this.label_title.AutoSize = true;
            this.label_title.BackColor = System.Drawing.Color.Transparent;
            this.label_title.Font = new System.Drawing.Font("Rubik", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(100)))), ((int)(((byte)(231)))));
            this.label_title.Location = new System.Drawing.Point(133, 26);
            this.label_title.Name = "label_title";
            this.label_title.Size = new System.Drawing.Size(244, 57);
            this.label_title.TabIndex = 0;
            this.label_title.Text = "TransTool";
            // 
            // linkLabel_login
            // 
            this.linkLabel_login.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(100)))), ((int)(((byte)(231)))));
            this.linkLabel_login.AutoSize = true;
            this.linkLabel_login.Font = new System.Drawing.Font("Rubik", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel_login.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.linkLabel_login.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(100)))), ((int)(((byte)(231)))));
            this.linkLabel_login.Location = new System.Drawing.Point(318, 373);
            this.linkLabel_login.Name = "linkLabel_login";
            this.linkLabel_login.Size = new System.Drawing.Size(67, 18);
            this.linkLabel_login.TabIndex = 1;
            this.linkLabel_login.TabStop = true;
            this.linkLabel_login.Text = "Register";
            this.linkLabel_login.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(100)))), ((int)(((byte)(231)))));
            this.linkLabel_login.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel_login_LinkClicked);
            // 
            // label_loginText
            // 
            this.label_loginText.AutoSize = true;
            this.label_loginText.Font = new System.Drawing.Font("Rubik", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_loginText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(112)))), ((int)(((byte)(112)))));
            this.label_loginText.Location = new System.Drawing.Point(145, 374);
            this.label_loginText.Name = "label_loginText";
            this.label_loginText.Size = new System.Drawing.Size(178, 15);
            this.label_loginText.TabIndex = 2;
            this.label_loginText.Text = "You don\'t have an Account?";
            // 
            // textBox_email
            // 
            this.textBox_email.AccessibleName = "";
            this.textBox_email.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(30)))), ((int)(((byte)(33)))));
            this.textBox_email.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_email.Font = new System.Drawing.Font("Rubik", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_email.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(100)))), ((int)(((byte)(231)))));
            this.textBox_email.Location = new System.Drawing.Point(150, 148);
            this.textBox_email.MaxLength = 500;
            this.textBox_email.Name = "textBox_email";
            this.textBox_email.Size = new System.Drawing.Size(233, 19);
            this.textBox_email.TabIndex = 3;
            // 
            // textBox_password
            // 
            this.textBox_password.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(30)))), ((int)(((byte)(33)))));
            this.textBox_password.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_password.Font = new System.Drawing.Font("Rubik", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_password.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(100)))), ((int)(((byte)(231)))));
            this.textBox_password.Location = new System.Drawing.Point(150, 222);
            this.textBox_password.MaxLength = 100;
            this.textBox_password.Name = "textBox_password";
            this.textBox_password.Size = new System.Drawing.Size(233, 19);
            this.textBox_password.TabIndex = 4;
            // 
            // checkBox_remember
            // 
            this.checkBox_remember.AutoSize = true;
            this.checkBox_remember.Font = new System.Drawing.Font("Rubik", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox_remember.ForeColor = System.Drawing.Color.White;
            this.checkBox_remember.Location = new System.Drawing.Point(124, 270);
            this.checkBox_remember.Name = "checkBox_remember";
            this.checkBox_remember.Size = new System.Drawing.Size(136, 23);
            this.checkBox_remember.TabIndex = 5;
            this.checkBox_remember.Text = "Remember me";
            this.checkBox_remember.UseVisualStyleBackColor = true;
            // 
            // label_email
            // 
            this.label_email.AutoSize = true;
            this.label_email.Font = new System.Drawing.Font("Rubik", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_email.ForeColor = System.Drawing.Color.White;
            this.label_email.Location = new System.Drawing.Point(134, 117);
            this.label_email.Name = "label_email";
            this.label_email.Size = new System.Drawing.Size(64, 25);
            this.label_email.TabIndex = 6;
            this.label_email.Text = "Email";
            // 
            // label_password
            // 
            this.label_password.AutoSize = true;
            this.label_password.Font = new System.Drawing.Font("Rubik", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_password.ForeColor = System.Drawing.Color.White;
            this.label_password.Location = new System.Drawing.Point(134, 191);
            this.label_password.Name = "label_password";
            this.label_password.Size = new System.Drawing.Size(108, 25);
            this.label_password.TabIndex = 7;
            this.label_password.Text = "Password";
            // 
            // button_submit
            // 
            this.button_submit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(100)))), ((int)(((byte)(231)))));
            this.button_submit.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(100)))), ((int)(((byte)(231)))));
            this.button_submit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_submit.Font = new System.Drawing.Font("Rubik", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_submit.ForeColor = System.Drawing.Color.White;
            this.button_submit.Location = new System.Drawing.Point(169, 317);
            this.button_submit.Name = "button_submit";
            this.button_submit.Size = new System.Drawing.Size(170, 34);
            this.button_submit.TabIndex = 8;
            this.button_submit.Text = "Start Transfer";
            this.button_submit.UseVisualStyleBackColor = false;
            this.button_submit.Click += new System.EventHandler(this.button_submit_Click);
            // 
            // panel_email
            // 
            this.panel_email.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(41)))), ((int)(((byte)(46)))));
            this.panel_email.Location = new System.Drawing.Point(124, 170);
            this.panel_email.Name = "panel_email";
            this.panel_email.Size = new System.Drawing.Size(260, 3);
            this.panel_email.TabIndex = 9;
            // 
            // panel_password
            // 
            this.panel_password.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(41)))), ((int)(((byte)(46)))));
            this.panel_password.Location = new System.Drawing.Point(123, 244);
            this.panel_password.Name = "panel_password";
            this.panel_password.Size = new System.Drawing.Size(260, 3);
            this.panel_password.TabIndex = 10;
            // 
            // pictureBox_email
            // 
            this.pictureBox_email.Image = global::TransTool.Properties.Resources.white_new_post_52px;
            this.pictureBox_email.Location = new System.Drawing.Point(124, 147);
            this.pictureBox_email.Name = "pictureBox_email";
            this.pictureBox_email.Size = new System.Drawing.Size(20, 20);
            this.pictureBox_email.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_email.TabIndex = 12;
            this.pictureBox_email.TabStop = false;
            // 
            // pictureBox_password
            // 
            this.pictureBox_password.Image = global::TransTool.Properties.Resources.white_lock_52px;
            this.pictureBox_password.Location = new System.Drawing.Point(124, 221);
            this.pictureBox_password.Name = "pictureBox_password";
            this.pictureBox_password.Size = new System.Drawing.Size(20, 20);
            this.pictureBox_password.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_password.TabIndex = 11;
            this.pictureBox_password.TabStop = false;
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(30)))), ((int)(((byte)(33)))));
            this.ClientSize = new System.Drawing.Size(512, 450);
            this.Controls.Add(this.linkLabel_login);
            this.Controls.Add(this.pictureBox_email);
            this.Controls.Add(this.pictureBox_password);
            this.Controls.Add(this.panel_password);
            this.Controls.Add(this.panel_email);
            this.Controls.Add(this.button_submit);
            this.Controls.Add(this.label_password);
            this.Controls.Add(this.label_email);
            this.Controls.Add(this.checkBox_remember);
            this.Controls.Add(this.textBox_password);
            this.Controls.Add(this.textBox_email);
            this.Controls.Add(this.label_loginText);
            this.Controls.Add(this.label_title);
            this.Font = new System.Drawing.Font("Rubik", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form_login";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormLogin_FormClosed);
            this.Load += new System.EventHandler(this.FormLogin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_email)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_password)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_title;
        private System.Windows.Forms.LinkLabel linkLabel_login;
        private System.Windows.Forms.Label label_loginText;
        private System.Windows.Forms.TextBox textBox_email;
        private System.Windows.Forms.TextBox textBox_password;
        private System.Windows.Forms.CheckBox checkBox_remember;
        private System.Windows.Forms.Label label_email;
        private System.Windows.Forms.Label label_password;
        private System.Windows.Forms.Button button_submit;
        private Panel panel_email;
        private Panel panel_password;
        private PictureBox pictureBox_password;
        private PictureBox pictureBox_email;
    }
}

