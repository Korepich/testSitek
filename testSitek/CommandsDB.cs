using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;
using System.CodeDom.Compiler;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace testSitek
{
    internal class CommandsDB
    {
        public static int sumRCC = 0;
        public static int sumReq = 0;
        public static int total = 0;
        public static int count = 0;

        public void addRCC(string executor_)
        {
            ConnectDB db = new ConnectDB();
            db.connectSql();
            db.npgsqlConnection.Open();

            SqlCommand command = new SqlCommand("SELECT COUNT(*) FROM [Table] WHERE Executor=@Executor", db.npgsqlConnection);
            command.Parameters.AddWithValue("Executor", executor_);
            if ((int)command.ExecuteScalar() != 0)
            {
                SqlCommand cmd = new SqlCommand("UPDATE [Table] SET RCC = RCC + 1 WHERE Executor=@Executor", db.npgsqlConnection);
                cmd.Parameters.AddWithValue("Executor", executor_);
                cmd.ExecuteNonQuery();
            }
            else
            {
                SqlCommand cmd = new SqlCommand("INSERT INTO [Table] (Executor, RCC, Appeals) VALUES (@Executor, 1, 0)", db.npgsqlConnection);
                cmd.Parameters.AddWithValue("Executor", executor_);
                cmd.ExecuteNonQuery();
            }
            db.npgsqlConnection.Close();
        }

        public void addReq(string executor_)
        {
            ConnectDB db = new ConnectDB();
            db.connectSql();
            db.npgsqlConnection.Open();

            SqlCommand command = new SqlCommand("SELECT COUNT(*) FROM [Table] WHERE Executor=@Executor", db.npgsqlConnection);
            command.Parameters.AddWithValue("Executor", executor_);
            if ((int)command.ExecuteScalar() != 0)
            {
                SqlCommand cmd = new SqlCommand("UPDATE [Table] SET Appeals = Appeals + 1 WHERE Executor=@Executor", db.npgsqlConnection);
                cmd.Parameters.AddWithValue("Executor", executor_);
                cmd.ExecuteNonQuery();
            }
            else
            {
                SqlCommand cmd = new SqlCommand("INSERT INTO [Table] (Executor, Appeals, RCC) VALUES (@Executor, 1, 0)", db.npgsqlConnection);
                cmd.Parameters.AddWithValue("Executor", executor_);
                cmd.ExecuteNonQuery();
            }
            db.npgsqlConnection.Close();
        }

        public void setSum()
        {
            List<int> list = new List<int>();
            List<int> list1 = new List<int>();
            ConnectDB db = new ConnectDB();
            db.connectSql();
            db.npgsqlConnection.Open();

            SqlCommand command = new SqlCommand("SELECT RCC FROM [Table]", db.npgsqlConnection);
            SqlDataReader reader = command.ExecuteReader();

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    list.Add((int)(reader.GetValue(0)));
                    sumRCC += (int)reader.GetValue(0);
                }
            }
            reader.Close();

            SqlCommand command1 = new SqlCommand("SELECT Appeals FROM [Table]", db.npgsqlConnection);
            SqlDataReader reader1 = command1.ExecuteReader();

            if (reader1.HasRows)
            {
                while (reader1.Read())
                {
                    list1.Add((int)(reader1.GetValue(0)));
                    sumReq += (int)(reader1.GetValue(0));
                }
            }
            reader1.Close();

            for (int i = 0; i < list.Count; i++)
            {
                list[i] = list[i] + list1[i];
                total += list[i];
            }

            count = list.Count + 1;

            for (int i = 0; i < list.Count; i++)
            {
                int id = i + 1;
                SqlCommand command2 = new SqlCommand("UPDATE [Table] SET Amount = @Amount WHERE ID = @ID", db.npgsqlConnection);
                command2.Parameters.AddWithValue("Amount", list[i]);
                command2.Parameters.AddWithValue("ID", id);
                command2.ExecuteNonQuery();
            }
            db.npgsqlConnection.Close();
        }

        public void clearTable()
        {
            ConnectDB db = new ConnectDB();
            db.connectSql();
            db.npgsqlConnection.Open();

            SqlCommand command = new SqlCommand("TRUNCATE Table [Table]", db.npgsqlConnection);
            command.ExecuteNonQuery();

            db.npgsqlConnection.Close();
        }

        public void selectAll()
        {
            ConnectDB db = new ConnectDB();
            db.connectSql();
            db.npgsqlConnection.Open();

            SqlCommand command = new SqlCommand("SELECT * FROM [Table]", db.npgsqlConnection);

            db.npgsqlConnection.Close();
        }
    }
}
