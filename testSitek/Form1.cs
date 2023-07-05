using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static testSitek.ReadFile;
using static testSitek.Report;
using Microsoft.EntityFrameworkCore;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Data.SqlClient;

namespace testSitek
{
    public partial class Form1 : Form
    {
        public static string path1;
        public static string path2;
        public static DateTime time = DateTime.Now;
        //private ConnectDB db = new ConnectDB();

        public Form1()
        {
            InitializeComponent();
        }


        private void firstChoice_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                textFirstPath.Text = openFileDialog1.FileName;
                path1 = openFileDialog1.FileName;
            }
        }

        private void secondChoice_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                textSecondPath.Text = openFileDialog1.FileName;
                path2 = openFileDialog1.FileName;
            }
        }

        private void createReport_Click(object sender, EventArgs e)
        {
            var sw = new Stopwatch();
            sw.Start();
            CommandsDB cMD = new CommandsDB();
            cMD.clearTable();
            ReadFile read = new ReadFile();
            read.readRCC(path1);
            read.readAppeals(path2);
            cMD.setSum();
            sw.Stop();

            speedAlg.Text = sw.Elapsed.ToString();

            ConnectDB db = new ConnectDB();
            db.connectSql();
            db.npgsqlConnection.Open();

            NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter("SELECT * FROM [Table]", db.npgsqlConnection);
            DataSet dataSet = new DataSet();
            dataAdapter.Fill(dataSet);

            dataGridView1.DataSource = dataSet.Tables[0];

        }

        private void sortSelect_Click(object sender, EventArgs e)
        {

        }

        private void choiceSorting_SelectedIndexChanged(object sender, EventArgs e)
        {
            NpgsqlCommand command = new NpgsqlCommand();
            switch (choiceSorting.SelectedIndex)
            {
                case 0:
                    (dataGridView1.DataSource as DataTable).DefaultView.Sort = $"Executor DESC";
                    break;


                case 1:
                    (dataGridView1.DataSource as DataTable).DefaultView.Sort = $"RCC DESC, Appeals DESC";
                    break;


                case 2:
                    (dataGridView1.DataSource as DataTable).DefaultView.Sort = $"Appeals DESC, RCC DESC";
                    break;


                case 3:
                    (dataGridView1.DataSource as DataTable).DefaultView.Sort = $"Amount DESC, RCC DESC";
                    break;
            }
        }
    }
}
