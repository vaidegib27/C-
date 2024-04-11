using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batch_1_c__demo
{
    internal class inhertance
    {
        public class animal
        {
            public void eating()
            {
                Console.WriteLine("animal eating");
            }

            public void sleeping() {

                Console.WriteLine("Sleeping animal");

            }
        }

        public class Domasticanimal:animal
        {
        public void place() {
            Console.WriteLine("Domastic animals will be at home");
            }
        }

        public class wildanimlas:animal { 
            public void place2()
            {
                Console.WriteLine("Wild animals is in Forest");
            }
        }


        public static void Main(string[] args)
        {
            Domasticanimal obj= new Domasticanimal();
            obj.eating();
            obj.sleeping();
            obj.place();
        }
    }
}
