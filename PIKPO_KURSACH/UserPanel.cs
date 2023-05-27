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

namespace PIKPO_KURSACH
{
    public partial class UserPanel : Form
    {
        private SQLiteCommandBuilder builder = null;
        private SQLiteDataAdapter sqliteDataAdapter = null;
        private SQLiteConnection sQLiteConnection = null;
        private DataSet dataSet = null;

        Connection con = new Connection();

        public UserPanel()
        {
            InitializeComponent();
        }

        private void LoadData()
        {
            sqliteDataAdapter = new SQLiteDataAdapter("SELECT *, 'Buy' AS [Buy] FROM Books", sQLiteConnection);
            builder = new SQLiteCommandBuilder(sqliteDataAdapter);

            dataSet = new DataSet();

            sqliteDataAdapter.Fill(dataSet, "Books");

            dgvViewer.DataSource = dataSet.Tables["Books"];

            for (int i = 0; i < dgvViewer.Rows.Count; i++)
            {
                DataGridViewLinkCell link = new DataGridViewLinkCell();
                dgvViewer[6, i] = link;
            }
        }

        private void UserPanel_Load(object sender, EventArgs e)
        {
            sQLiteConnection = new SQLiteConnection("Data Source = D:/DB/database.db");
            sQLiteConnection.Open();
            LoadData();
        }

        private void button_profile_Click(object sender, EventArgs e)
        {
            FormsForUserPanel.Profile profile = new FormsForUserPanel.Profile();
            profile.Show();
        }

        private void button_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvViewer_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.ColumnIndex == 6)
                {
                    string cmd = dgvViewer.Rows[e.RowIndex].Cells[6].Value.ToString(); // Получили текст из линк лейбла

                    if (cmd == "Buy")
                    {

                        if (MessageBox.Show("Подтеврдить покупку?", "Покупка", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            int buy = Convert.ToInt32(dataSet.Tables["Books"].Rows[e.RowIndex]["count"]);
                            int count = 0;
                            if (buy != 0)
                            {
                                try
                                {
                                    dataSet.Tables["Books"].Rows[e.RowIndex]["count"] = Convert.ToInt32(dgvViewer.Rows[e.RowIndex].Cells["count"].Value) - 1;
                                    sqliteDataAdapter.Update(dataSet, "Books");
                                    dgvViewer.Rows[e.RowIndex].Cells[6].Value = "Buy";
                                    count = Convert.ToInt32(dataSet.Tables["Books"].Rows[e.RowIndex]["count"]);


                                    con.Open();
                                    SQLiteDataReader row;
                                    string query = "SELECT * FROM Users WHERE login = 1";
                                    row = con.ExecuteReader(query);
                                    count = 228;
                                    string add = "UPDATE Users SET buy = ('"+ count.ToString() +"') WHERE login = 1";
                                    con.ExecuteNonQuery(add);

                                    Refresh();
                                }
                                catch (Exception exp)
                                {
                                    MessageBox.Show("Ошибка подключения к БД " + exp.Message);
                                }

                            }
                            else
                            {
                                MessageBox.Show("Книги нет в наличии");
                            }
                        }

                        Refresh();
                    }
                }
            }
            catch (Exception exp)
            {
                MessageBox.Show("Ошибка подключения к БД " + exp.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*con.Open();
            SQLiteDataReader row;
            string query = "SELECT * FROM Users";
            row = con.ExecuteReader(query);
            string add = "UPDATE Users SET buy = 1 WHERE id = 2";
            con.ExecuteNonQuery(add);*/
        }
    }
}
