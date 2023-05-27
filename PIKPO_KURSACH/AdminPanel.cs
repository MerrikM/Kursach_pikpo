using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;

namespace PIKPO_KURSACH
{
    public partial class AdminPanel : Form
    {

        public string login;
        public string password;
        public void import(string _l, string _p)
        {
            login = _l;
            password = _p;
        }

        public AdminPanel()
        {
            InitializeComponent();
        }

        private void supplier_directory_Click(object sender, EventArgs e)
        {
            FormsFromAdminPanel.supplier_directory supplier_directory = new FormsFromAdminPanel.supplier_directory();
            supplier_directory.Show();
        }

        private void book_catalog_Click(object sender, EventArgs e)
        {
            FormsFromAdminPanel.book_catalog book_catalog = new FormsFromAdminPanel.book_catalog();
            book_catalog.Show();
        }

        private void admission_Click(object sender, EventArgs e)
        {
            FormsFromAdminPanel.admission admission = new FormsFromAdminPanel.admission();
            admission.Show();
        }

        private void sale_Click(object sender, EventArgs e)
        {
            FormsFromAdminPanel.sale sale = new FormsFromAdminPanel.sale();
            sale.Show();
        }

        private void search_Click(object sender, EventArgs e)
        {
            FormsFromAdminPanel.search search = new FormsFromAdminPanel.search();
            search.Show();
        }
    }
}
