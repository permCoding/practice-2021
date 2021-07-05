using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace word_blank
{
    class DbHelper
    {
        public static MySqlConnection GetConn()
        {
            MySqlConnectionStringBuilder db = new MySqlConnectionStringBuilder();

            db.Server = "pgsha.ru"; // хостинг БД
            db.Database = "practice"; // Имя БД
            db.UserID = "practice"; // Имя пользователя БД
            db.Password = "0000"; // Пароль пользователя БД
            db.Port = 35006;
            db.CharacterSet = "utf8"; // Кодировка Базы Данных

            MySqlConnection conn = new MySqlConnection(db.ConnectionString);

            return conn;
        }
    }
}
