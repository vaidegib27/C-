using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace democ_
{
    internal class Calmethod
    {
        public class Operations_cal
        {
            public void sum(int a ,int b)
            {
                Console.WriteLine($"{a+b}");
                    
            }

            public void sub(int a ,int b)
            {
                Console.WriteLine($"{a - b}");
            }

            public void multiply(int a ,int b)
            {
                Console.WriteLine($"{a * b}");
            }

            public void divide(int a ,int b)
            {
                Console.WriteLine($"{a/b}");
            }




        }

        public class data
        {
            public int id { get; set; }
            public string Name { get; set; }

            public string natiionality { get; set; }
        }
    }
}
