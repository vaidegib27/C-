using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace level2_c_
{
    internal class inhertence
    {
        public class gf //thatha
        {
            public void thathaland()
            {
                Console.WriteLine("40 hecter land");
            }
        }

        public class parents : gf //parents
        {
            public void parent()
            {
                Console.WriteLine("i'm parent i can avail land");
            }
        }

        public class narmathaclass : parents  //narmi
        {
            public void Narmatha()
            {
                Console.WriteLine("land is mine");
            }
        }

        public static void Main(string[] args)
        {
            narmathaclass onj = new narmathaclass();
            onj.thathaland();
            onj.parent();
            onj.Narmatha();

        }


    }
}
