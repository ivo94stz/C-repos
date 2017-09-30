using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7
{
    class Program
    {
        static void Main(string[] args)
        {
            var ingredients = Console.ReadLine();
            var count = 0;

            while (ingredients != "Bake!")
            {
                Console.WriteLine("Adding ingredient {0}.", ingredients);
                ingredients = Console.ReadLine();
                count++;

            }
            Console.WriteLine("Preparing cake with {0} ingredients.", count);

        }
    }
}
