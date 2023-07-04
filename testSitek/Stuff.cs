using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testSitek
{
    internal class Stuff
    {
        public string Director { get; set; }
        public string Executor { get; set; }
        public int Count { get; set; }

        public Stuff(string director_, string executor_, int count_)
        {
            Director = director_;   //RK= rk_
            Executor = executor_;   //Otv= otv_
            Count = count_;
        }

        public Stuff()
        {
            Director = "";  
            Executor = "";
            Count = 0;
        }

    }
}
