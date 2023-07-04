using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace testSitek
{
    public partial class Form1 : Form
    {
        public static string path1;
        public static string path2;
        private ConnectDB db = new ConnectDB();

        public Form1()
        {
            InitializeComponent();
        }


        private void firstChoice_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                textFirstPath.Text = openFileDialog1.FileName;
                //labelFirstFile.Text = "Имя первого файла: " + Path.GetFileName(openFileDialog1.FileName);
                path1 = openFileDialog1.FileName;
                /*if (Path.GetFileName(openFileDialog1.FileName) == "Тестовое задание - РКК.txt")
                {
                    path1 = openFileDialog1.FileName;
                }
                else
                {
                    path2 = openFileDialog1.FileName;
                }*/
            }
        }

        private void secondChoice_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                textSecondPath.Text = openFileDialog1.FileName;
                //labelSecondFile.Text = "Имя второго файла: " + Path.GetFileName(openFileDialog1.FileName);
                path2 = openFileDialog1.FileName;
                /*if (Path.GetFileName(openFileDialog1.FileName) == "Тестовое задание - Обращения.txt")
                {
                    path2 = openFileDialog1.FileName;
                }
                else
                {
                    path1 = openFileDialog1.FileName;
                }*/
            }
        }

        private void createReport_Click(object sender, EventArgs e)
        {

        }

        private void sortSelect_Click(object sender, EventArgs e)
        {

        }
    }
}
