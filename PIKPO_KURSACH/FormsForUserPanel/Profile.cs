using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PIKPO_KURSACH.FormsForUserPanel
{
    public partial class Profile : Form
    {
        public Profile()
        {
            InitializeComponent();
            LoginForm loginform = new LoginForm();
            login.Text = loginform.textBox_login.Text;
            password.Text = loginform.textBox_password.Text;
        }

        public string Login
        {
            get { return login.Text; }
            set { login.Text = value; }
        }

        public string Password
        {
            get { return password.Text; }
            set { password.Text = value; }
        }

        private void button_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}
