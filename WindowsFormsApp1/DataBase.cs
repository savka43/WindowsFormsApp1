using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace WindowsFormsApp1
{
    internal class DataBase
    {
        // Подключение к MSSQL
        private SqlConnection sqlConnection = new SqlConnection(
            @"Data Source=localhost\SQLEXPRESS;Initial Catalog=GIBDDKURS;Integrated Security=True");

        // Открытие соединения
        public void openConnection()
        {
            if (sqlConnection.State == System.Data.ConnectionState.Closed)
            {
                sqlConnection.Open();
            }
        }

        // Закрытие соединения
        public void closeConnection()
        {
            if (sqlConnection.State == System.Data.ConnectionState.Open)
            {
                sqlConnection.Close();
            }
        }

        // Получение объекта подключения
        public SqlConnection getConnection()
        {
            return sqlConnection;
        }
    }
}