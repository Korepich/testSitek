using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;
using System.CodeDom.Compiler;
using System.Windows.Forms;

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

            NpgsqlCommand command = new NpgsqlCommand("SELECT COUNT(*) FROM public.\"ReportTable\" WHERE \"Executor\"=@Executor", db.npgsqlConnection);
            command.Parameters.AddWithValue("Executor", executor_);
            if ((long)command.ExecuteScalar() != 0)
            {
                NpgsqlCommand cmd = new NpgsqlCommand("UPDATE public.\"ReportTable\" SET \"RCC\" = \"RCC\" + 1 WHERE \"Executor\"=@Executor", db.npgsqlConnection);
                cmd.Parameters.AddWithValue("Executor", executor_);
                cmd.ExecuteNonQuery();
            }
            else
            {
                NpgsqlCommand cmd = new NpgsqlCommand("INSERT INTO public.\"ReportTable\" (\"Executor\", \"RCC\", \"Appeals\") VALUES (@Executor, 1, 0)", db.npgsqlConnection);
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

            NpgsqlCommand command = new NpgsqlCommand("SELECT COUNT(*) FROM public.\"ReportTable\" WHERE \"Executor\"=@Executor", db.npgsqlConnection);
            command.Parameters.AddWithValue("Executor", executor_);
            if ((long)command.ExecuteScalar() != 0)
            {
                NpgsqlCommand cmd = new NpgsqlCommand("UPDATE public.\"ReportTable\" SET \"Appeals\" = \"Appeals\" + 1 WHERE \"Executor\"=@Executor", db.npgsqlConnection);
                cmd.Parameters.AddWithValue("Executor", executor_);
                cmd.ExecuteNonQuery();
            }
            else
            {
                NpgsqlCommand cmd = new NpgsqlCommand("INSERT INTO public.\"ReportTable\" (\"Executor\", \"Appeals\", \"RCC\") VALUES (@Executor, 1, 0)", db.npgsqlConnection);
                cmd.Parameters.AddWithValue("Executor", executor_);
                cmd.ExecuteNonQuery();
            }
            db.npgsqlConnection.Close();
        }

        public void setSum()
        {
            Dictionary<int, int> list = new Dictionary<int, int>();
            Dictionary<int, int> list1 = new Dictionary<int, int>();
            ConnectDB db = new ConnectDB();
            db.connectSql();
            db.npgsqlConnection.Open();

            NpgsqlCommand command = new NpgsqlCommand("SELECT \"ID\", \"RCC\" FROM public.\"ReportTable\"", db.npgsqlConnection);
            NpgsqlDataReader reader = command.ExecuteReader();

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    list.Add(reader.GetInt32(0), reader.GetInt32(1));
                    sumRCC += reader.GetInt32(1);
                }
            }
            reader.Close();

            NpgsqlCommand command1 = new NpgsqlCommand("SELECT \"ID\", \"Appeals\" FROM public.\"ReportTable\"", db.npgsqlConnection);
            NpgsqlDataReader reader1 = command1.ExecuteReader();

            if (reader1.HasRows)
            {
                while (reader1.Read())
                {
                    list1.Add(reader.GetInt32(0), reader.GetInt32(1));
                    sumReq += reader.GetInt32(1);
                }
            }
            reader1.Close();

            foreach (var key in list.Keys.ToList())
            {
                list[key] = list[key] + list1[key];
                total += list[key];
            }

            count = list.Count + 1;

            for (int i = 1; i <= list.Count; i++)
            {
                //int id = i + 1;
                NpgsqlCommand command2 = new NpgsqlCommand("UPDATE public.\"ReportTable\" SET \"Amount\" = @Amount WHERE \"ID\" = @ID", db.npgsqlConnection);
                command2.Parameters.AddWithValue("Amount", list[i]);
                command2.Parameters.AddWithValue("ID", i);
                command2.ExecuteNonQuery();
            }
            db.npgsqlConnection.Close();
        }

        public void clearTable()
        {
            ConnectDB db = new ConnectDB();
            db.connectSql();
            db.npgsqlConnection.Open();

            NpgsqlCommand command = new NpgsqlCommand("TRUNCATE ONLY public.\"ReportTable\" RESTART IDENTITY", db.npgsqlConnection);
            command.ExecuteNonQuery();

            db.npgsqlConnection.Close();
        }

        public void selectAll()
        {
            ConnectDB db = new ConnectDB();
            db.connectSql();
            db.npgsqlConnection.Open();

            NpgsqlDataAdapter command = new NpgsqlDataAdapter("SELECT * FROM public.\"ReportTable\"", db.npgsqlConnection);

            db.npgsqlConnection.Close();
        }


    }
}
