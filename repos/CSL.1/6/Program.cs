using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = int.Parse(Console.ReadLine());
            var b = int.Parse(Console.ReadLine());

            if (a - b > 0)
            {
                for (int x = b; x <= a; x++)
                {
                    Console.WriteLine(x);
                }
            }
            else
            {
                
                
                for (int x = a; x <= b; x++)
                {
                    Console.WriteLine(x);
                }
            }
            
        }
    }
}
