using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace democ_
{
    internal class Oops
    {
        public class Animal
        {
            public void Eating()
            {
                Console.WriteLine("Eating ia primary for all animals");
            }
        }
        //Adding inheritance 
        public class Dog:Animal
        {
            public void barking()
            {
                Console.WriteLine("Barking is the primary activity of dog");
            }
        }


        public static void Main(string[] args)
        {
            Dog dog = new Dog();
            dog.barking();
            dog.Eating();


            //We have created separate method in separate class we are using that  here by creating object 
            Calmethod.Operations_cal C= new Calmethod.Operations_cal();
            C.sum(5, 2);
            C.divide(6,2);
            

            Calmethod.data d= new Calmethod.data();
            d.Name = "dev";
            d.Name = "dev2";

            Console.WriteLine(d.Name);
        }
    }


}
