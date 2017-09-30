using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4._10
{
    class Program
    {
        static void Main(string[] args)
        {
            var animal = Console.ReadLine();

            if (animal == "dog") Console.WriteLine("mammal");
            else if (animal == "crocodile" || animal == "tortoise" || animal == "snake") Console.WriteLine("reptile");
            else Console.WriteLine("unknown");
        }
    }
}
