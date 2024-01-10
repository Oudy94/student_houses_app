using student_houses_app.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace student_houses_app
{
    public partial class frmLogin : Form
    {
        private readonly DatabaseHelper db;
        private Main main;
        public frmLogin(Main main)
        {
            InitializeComponent();

            this.main = main;

            this.db = new DatabaseHelper();
            txtUsername.Height = 40;
            txtPassword.Height = 40;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            if (!string.IsNullOrWhiteSpace(username) && !string.IsNullOrWhiteSpace(password))
            {
                db.OpenConnection();
                if (db.AuthenticateUser(username, password))
                {
                    MessageBox.Show("Login succefully.");
                    main.OpenMainAdmin();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("There is no account with these credentials.");
                }
                db.CloseConnection();
            }
        }

        private void chkShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (chkShowPassword.Checked)
            {
                txtPassword.PasswordChar = '\0';
            }
            else
            {
                txtPassword.PasswordChar = '*';
            }
        }
    }
}
