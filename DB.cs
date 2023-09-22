using System;
using System.Data.SqlClient;

namespace LearnSQL
{
    class DB
    {
        SqlConnection connection = new SqlConnection(@"Data Source=192.168.1.1\LOCALLOGINSERVER;Persist Security Info=True;User ID=root;Password=pass");

        public void OpenConnection()
        {
            if (connection.State == System.Data.ConnectionState.Closed)
            {
                connection.Open();
            }
        }

        public void CloseConnection()
        {
            if (connection.State == System.Data.ConnectionState.Open)
            {
                connection.Close();
            }
        }

        public SqlConnection GetConnection()
        {
            return connection;
        }
    }
}
