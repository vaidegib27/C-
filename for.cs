using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace level2_c_
{
    internal class loops{
        public static void Main(string[] args)
        {
            Console.Write("Enter the value;");
            int i = Convert.ToInt32(Console.ReadLine());
            for (int y = 0; y <= i; y++)
            {
                Console.WriteLine(y);
            }
        }
    }
}
