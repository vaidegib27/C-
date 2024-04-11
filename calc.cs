using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace level2_c_
{
    internal class calc
    {

        public class operation
        {
            public void add(int a, int b)
            {
                Console.WriteLine($"The sum of two number {a + b}");
            }
            public void sub(int a, int b)
            {
                Console.WriteLine($"The sub of two number {a - b}");
            }
            public void multiply(int a, int b)
            {
                Console.WriteLine($"The multiply of two number {a * b}");
            }


        }
        public static void Main(string[] args)
        {
            operation sam = new operation();
            Console.WriteLine("Enter the Two number");
            int input1 = Convert.ToInt32(Console.ReadLine());
            int input2 = Convert.ToInt32(Console.ReadLine());
            sam.add(input1, input2);
        }
    }
}
