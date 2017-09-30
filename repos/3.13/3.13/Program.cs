using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._13
{
    class Program
    {
        static void Main(string[] args)
        {
            var duma1 = Console.ReadLine();
            var duma2 = Console.ReadLine();
            duma1 = duma1.ToLower();
            duma2 = duma2.ToLower();
            if (duma1 == duma2)
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }
        }
    }
}
