using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace democ_
{
    internal class io
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Enter your name");
            //string userName = Console.ReadLine();
            //Console.WriteLine($"hey Welcome to heta college of Technology Mr.{userName}");


            //if condition
            //Console.WriteLine("Enter your user Name");
            //string UserName = Console.ReadLine();
            //Console.WriteLine($"Welcome to college portal Mr.{UserName}");
            //Console.WriteLine("Enter your Password");
            //string Password = Console.ReadLine();

            //if (Password == "Dev" || Password == "dev")
            //{
            //    Console.WriteLine("Welcome bruh !");
            //}
            //else
            //{
            //    Console.WriteLine("Vellila poda");
            //}

            //looping
            //Console.WriteLine("enter the number which you need to generate the table");
            //int Tablenumber = Convert.ToInt32(Console.ReadLine());
            ////for (int i = 1; i <= 20; i++)
            //{
            //   // Console.WriteLine("If condition");
            //    Console.WriteLine($"{Tablenumber} X {i} = {Tablenumber * i}");
            //}

            //Console.WriteLine("While Loop");
            //int j = 1;
            //while (j <= 10)
            //{
            //    Console.WriteLine($"{Tablenumber} X {j} = {Tablenumber * j}");
            //    j++;
            //}


            //Switch case
            Console.WriteLine("Enter the package you want to get \n 1.Normal\n 2.primium \n 3.superprimium ");
            int number = Convert.ToInt32(Console.ReadLine());
            switch (number)
            {
                case 1:
                    {
                        Console.WriteLine("You choose super Normal package price 500");
                    }
                    break;
                case 2:
                    {
                        Console.WriteLine("You choose super primium700");
                    }
                    break;
                case 3:
                    {
                        Console.WriteLine("You choose super primium its price 1200/-");
                    }
                    break;
            }

            //method m = new method();
            //m.mymethode("dev");
        }
    }
}
