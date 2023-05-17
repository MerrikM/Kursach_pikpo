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
    public partial class LoginForm : Form
    {
        //private SQLiteConnection login = new SQLiteConnection("Data Source = D:/C++ Project/PIKPO_KURSACH/database.db");
        Connection con = new Connection();
        string id, login, password;
        public LoginForm()
        {
            InitializeComponent();
        }

        private void registration_Click(object sender, EventArgs e)
        {
            con.Open();
            SQLiteDataReader row;
            string query = "SELECT * FROM Users";
            row = con.ExecuteReader(query);

            try
            {
                if (textBox_login.Text != "" && textBox_password.Text != "")
                {
                    DialogResult dialogResult = MessageBox.Show("Логин пользователя и пароль будут добавленны в БД\nПодтвердить?", "Регистрация", MessageBoxButtons.YesNo);

                    if (dialogResult == DialogResult.Yes)
                    {
                        try
                        {
                            string add = "INSERT INTO Users ('login', 'password') VALUES ('" + textBox_login.Text + "' , '" + textBox_password.Text + "')";
                            con.ExecuteNonQuery(add);
                            //MessageBox.Show("Пользователь успешно зарегестрирован");
                        }
                        catch (SQLiteException ex)
                        {
                            MessageBox.Show("Error: " + ex.Message + "\n");
                        }
                    }

                    else if (dialogResult == DialogResult.No)
                    {
                        textBox_login.Text = ""; textBox_password.Text = "";
                        error.Text = "Для входа или регистрации заполните поля «Логин» и «Пароль»";
                        error.ForeColor = Color.Red;
                    }
                }
            }
            catch (Exception exp)
            {
                MessageBox.Show("Ошибка подключения к БД " + exp.Message);
            }
            row.Close();
            con.Close();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            con.Open();
            SQLiteDataReader row;
            string query = "SELECT * FROM Users";
            row = con.ExecuteReader(query);

            try
            {
                error.Text = "";
                AdminPanel adminForm = new AdminPanel();
                UserPanel userForm = new UserPanel();

                if (textBox_login.Text != "" && textBox_password.Text != "")
                {
                    if (row.HasRows)
                    {
                        while (row.Read())
                        {
                            id = row["id"].ToString();
                            login = row["login"].ToString();
                            password = row["password"].ToString();

                            string admin = row["login"].ToString();
                            admin = "admin";
                            string adminPass = row["password"].ToString();
                            adminPass = "123";

                            if (textBox_login.Text.Trim() == login && textBox_password.Text.Trim() == password)
                            {
                                userForm.Show();
                            }

                            else if (textBox_login.Text.Trim() == admin && textBox_password.Text.Trim() == adminPass)
                            {
                                userForm.Close();
                                adminForm.Show();
                            }

                            else
                            {
                                error.Text = "Неверный логин или пароль";
                                error.ForeColor = Color.Red;
                            }
                        }
                    }
                }

                else
                {
                    error.Text = "Заполните поля «Логин» и «Пароль»";
                    error.ForeColor = Color.Red;
                }
            }
            catch (Exception exp)
            {
                MessageBox.Show("Ошибка подключения к БД " + exp.Message);
            }
            //row.Close();
            con.Close();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            /*SQLiteConnection login = new SQLiteConnection("Data Source = D:/C++ Project/PIKPO_KURSACH/database.db");
            try
            {
                login.Open();
            }
            catch
            {
                MessageBox.Show("Не удалось подключится к БД");
            }*/
        }
    }
}
