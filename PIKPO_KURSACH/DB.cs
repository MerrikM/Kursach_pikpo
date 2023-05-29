using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PIKPO_KURSACH
{
    class DB
    {
        private string login, password;
        Connection con = new Connection();
        public void add_user(string login, string password)
        {
            this.login = login;
            this.password = password;

            con.Open();
            SQLiteDataReader row;
            string query = "SELECT * FROM Users";
            row = con.ExecuteReader(query);

            string add = "INSERT INTO Users ('login', 'password', 'buy') VALUES ('" + login + "', '" + password + "', '" + 0 + "')";
            con.ExecuteNonQuery(add);

            row.Close();
            con.Close();
        }
    }
}

