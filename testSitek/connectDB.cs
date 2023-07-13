using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;

namespace testSitek
{
    internal class ConnectDB
    {
        public SqlConnection npgsqlConnection;
        public static string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename='|DataDirectory|\\Database1.mdf';Integrated Security=True";

        public void connectSql()
        {
            npgsqlConnection = new SqlConnection(connectionString);
            /*npgsqlConnection.Open();
            if ((npgsqlConnection.State == ConnectionState.Open))
            {
                Console.WriteLine("opened");
            }
            else
            {
                Console.WriteLine("closed");
            }*/
        }
    }
}
