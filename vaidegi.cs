using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace level2_c_
{
    internal class vaidegi
    {
        public class bike
        {
            public void parts()
            {
                Console.WriteLine("BIKE PARTS :)");
            }
            public void brake()
            {
                Console.WriteLine("break intergated");
            }
            public void wheel()
            {
                Console.WriteLine("wheel intergated");
            }
            public void clutch()
            {
                Console.WriteLine("clutch intergated");
            }
            public void steering()
            {
                Console.WriteLine("steering integrated");
            }
            public void light()
            {
                Console.WriteLine("light integrated");
            }

            public void summ(int a, int b)
            {
                Console.WriteLine($"The sum of two number{a+b}");
            }
           
            public static void Main(string[] args)
            {
                bike obj = new bike();
                obj.parts();
                obj.brake();
                obj.wheel();
                obj.clutch();
                obj.steering();
                obj.light();
                obj.summ(1, 2);
            }
            
        }
    }
}
