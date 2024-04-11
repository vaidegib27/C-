using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static level2_c_.calc;

namespace level2_c_
{
    internal class calculator
    {
        public class add
        {
            public void addition(int a, int b)
            {
                Console.WriteLine($"the add is two numbers:{a + b}");

            }
        }
        public class sub : add
        {
            public void subraction(int a, int b)
            {
                Console.WriteLine($"the subraction is:{a - b}");
            }
        }
        public class multi : sub
        {
            public void multiply(int a, int b)
            {
                Console.WriteLine($"the multiply is {a * b}");

            }


        }
        public class division : multi
        {
            public void div(int a, int b)
            {
                Console.WriteLine($"the division is {a / b}");

            }




        }
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter the two number");
            int intput = Convert.ToInt32(Console.ReadLine());
            int input2 = Convert.ToInt32(Console.ReadLine());
            division obj = new division();
            obj.addition(intput, input2);
            obj.multiply(input2, input2);
            obj.div(input2, input2);
            obj.subraction(input2, input2);
        }
    }





}
