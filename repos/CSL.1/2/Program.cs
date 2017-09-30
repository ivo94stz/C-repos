using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2
{
    class Program
    {
        static void Main(string[] args)
        {
            var profession = Console.ReadLine();
            var quantity = double.Parse(Console.ReadLine());
            var price = 0.0;
            if (profession == "Athlete") price = quantity * 0.7;
            else if (profession == "Businessman"|| profession=="Businesswoman") price = quantity * 1;
            else if (profession == "SoftUni Student") price = quantity * 1.7;
            else price = quantity * 1.2;

            Console.WriteLine("The {0} has to pay {1:f2}.", profession,price);



        }
    }
}
