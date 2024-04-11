using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace level2_c_
{
    internal class level3
    {
        public class yuvi
        {
            public void looper(int x) { 
            for(int y = 1;y<=x;y++)
                {
                    Console.WriteLine($"vakkam da mapla{y}");
                }
            }
        }

        public static void Main(string[] args)
        {
            yuvi u= new yuvi();
            u.looper(10);
        }
    }
}
