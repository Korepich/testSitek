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
        public NpgsqlConnection npgsqlConnection;
        public static string connectionString = "Server=127.0.0.1;Port=5432;Database=testSitek;User Id=postgres;Password=FktRcKY12;";

        public void connectSql()
        {
            npgsqlConnection = new NpgsqlConnection(connectionString);
            npgsqlConnection.Open();
            if ((npgsqlConnection.State == ConnectionState.Open))
            {
                Console.WriteLine("opened");
            }
            else
            {
                Console.WriteLine("closed");
            }
        }

        /*public static NpgsqlConnection GetConnection() 
        {
            return new NpgsqlConnection(@"Server=localhost;Port=5432;User Id=postgres;Password=FktRcKY12;Database=testSitek");
        
        }*/


    }
}
