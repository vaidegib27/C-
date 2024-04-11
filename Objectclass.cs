using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batch_1_c__demo
{
    internal class Objectclass
    {
        public class car
        {
            public string carmodel { get; set; }
            public string Type { get; set; }

            public void start()
            {
                Console.WriteLine("Car Started ..........");
            }

            public void Acclerate()
            {
                Console.WriteLine("Car Acclerated ..................");

            }

            public void Break()
            {
                Console.WriteLine("Break Applied");
            }

            public void Details() {
                Console.WriteLine($"car model :{carmodel} and type {Type}");
            }
        }

        public static void Main(string[] args)
        {
            car c= new car();
            c.start();
            c.Acclerate();
            c.Break();
            c.carmodel = "Audi Q4";
            c.Type = "XUV";
            c.Details();
        }
    }


}
