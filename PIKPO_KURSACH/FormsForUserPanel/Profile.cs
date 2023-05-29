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
        }
        public void importprof(string _l, string _p)
        {
            login.Text = _l;
            password.Text = _p;
        }
        private void button_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
