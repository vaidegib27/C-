using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace level2_c_
{
    internal class democlass
    {
        public class car
        {
            public void wheels() {
                Console.WriteLine("Wheels intergrated");
            }

            public void Engin()
            {
                Console.WriteLine("Engin intergarted");
            }
            public void gear()
            {
                Console.WriteLine("gear integrated");
            }
            public void brake()
            {
                Console.WriteLine("brake integrated");

            }
            public void steeringwheel()
            {
                Console.WriteLine(" steeringwheel integrated");
            }
            public void light()
            {
                Console.WriteLine("light integrated");
            }
                
        }


        public static void Main(string[] args)
        {
            car obj = new car();
            obj.wheels();
            obj.Engin();
            obj.gear();
            obj.brake();
            obj.steeringwheel();
        }


         
    }
}
