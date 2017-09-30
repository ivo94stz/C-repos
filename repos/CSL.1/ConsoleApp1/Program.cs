using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            var group = int.Parse(Console.ReadLine());
            var pack = Console.ReadLine();
            var price = 0.0;



            if(group <= 50)
            {
                if(pack == "Normal")
                {
                    price = (2500 + 500) * 0.95 / group;
                    Console.WriteLine("We can offer you the Small Hall");
                    Console.WriteLine("The price per person is {0:f2}$",price);
                }
                else if (pack == "Gold")
                {
                    price = (2500 + 750) * 0.9 / group;
                    Console.WriteLine("We can offer you the Small Hall");
                    Console.WriteLine("The price per person is {0:f2}$", price);
                }
                else if (pack == "Platinum")
                {
                    price = (2500 + 1000) * 0.85 / group;
                    Console.WriteLine("We can offer you the Small Hall");
                    Console.WriteLine("The price per person is {0:f2}$", price);
                }
            }


            else if (group > 50 && group<=100)
            {
                if (pack == "Normal")
                {
                    price = (5000 + 500) * 0.95 / group;
                    Console.WriteLine("We can offer you the Terrace");
                    Console.WriteLine("The price per person is {0:f2}$", price);
                }
                else if (pack == "Gold")
                {
                    price = (5000 + 750) * 0.9 / group;
                    Console.WriteLine("We can offer you the Terrace");
                    Console.WriteLine("The price per person is {0:f2}$", price);
                }
                else if (pack == "Platinum")
                {
                    price = (5000 + 1000) * 0.85 / group;
                    Console.WriteLine("We can offer you the Terrace");
                    Console.WriteLine("The price per person is {0:f2}$", price);
                }
            }


            else if (group > 100 && group<=120)
            {
                if (pack == "Normal")
                {
                    price = (7500 + 500) * 0.95 / group;
                    Console.WriteLine("We can offer you the Great Hall");
                    Console.WriteLine("The price per person is {0:f2}$", price);
                }
                else if (pack == "Gold")
                {
                    price = (7500 + 750) * 0.9 / group;
                    Console.WriteLine("We can offer you the Great Hall");
                    Console.WriteLine("The price per person is {0:f2}$", price);
                }
                else if (pack == "Platinum")
                {
                    price = (7500 + 1000) * 0.85 / group;
                    Console.WriteLine("We can offer you the Great Hall");
                    Console.WriteLine("The price per person is {0:f2}$", price);
                }
            }
            else Console.WriteLine("We do not have an appropriate hall.");


        }
    }
}
