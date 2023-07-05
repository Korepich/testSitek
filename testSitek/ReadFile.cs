using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testSitek
{
    internal class ReadFile
    {
        public void readRCC(string path)
        {
            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                string str;
                string str1 = " ";

                while ((line = reader.ReadLine()) != null)
                {
                    Stuff stuff = new Stuff();
                    stuff.Director = line.Substring(0, line.IndexOf('\t'));
                    if (stuff.Director != "Климов Сергей Александрович")
                    {
                        str = line.Substring(0, line.IndexOf('\t'));
                        for (int i = 0; i < str.Count(); i++)
                        {
                            char s = str[i];
                            if (char.IsUpper(s) == true)
                            {
                                StringBuilder sb = new StringBuilder(str1);
                                sb.Append(s);
                                sb.Append('.');
                                str1 = sb.ToString();
                            }
                        }
                        str1 = str1.Remove(1, 2);
                        stuff.Executor = stuff.Director.ToString().Substring(0, line.IndexOf(' ')) + str1;
                        str1 = " ";
                    }
                    else
                    {
                        stuff.Executor = line.Substring(line.IndexOf('\t') + 1, ((line.IndexOf('.') + 2) - line.IndexOf('\t')));
                    }
                    CommandsDB cmd = new CommandsDB(); 
                    cmd.addRCC(stuff.Executor);
                }

            }

        }

        public void readAppeals(string path)
        {
            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                string str;
                string str1 = " ";
                while ((line = reader.ReadLine()) != null)
                {
                    Stuff stuff = new Stuff();
                    stuff.Director = line.Substring(0, line.IndexOf('\t'));
                    if (stuff.Director != "Климов Сергей Александрович")
                    {
                        str = line.Substring(0, line.IndexOf('\t'));
                        for (int i = 0; i < str.Count(); i++)
                        {
                            char s = str[i];
                            if (char.IsUpper(s) == true)
                            {
                                StringBuilder sb = new StringBuilder(str1);
                                sb.Append(s);
                                sb.Append('.');
                                str1 = sb.ToString();
                            }
                        }
                        str1 = str1.Remove(1, 2);
                        stuff.Executor = stuff.Director.ToString().Substring(0, line.IndexOf(' ')) + str1;
                        str1 = " ";
                    }
                    else
                    {
                        stuff.Executor = line.Substring(line.IndexOf('\t') + 1, ((line.IndexOf('.') + 2) - line.IndexOf('\t')));
                    }
                    CommandsDB cmd = new CommandsDB();
                    cmd.addReq(stuff.Executor);
                }
            }
        }
    }
}
