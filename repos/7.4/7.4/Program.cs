using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7._4
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var n = int.Parse(Console.ReadLine());
                var x = 1;

                Console.WriteLine(x);
                for (int i = 0; i < n; i+=2)
                {

                    Console.WriteLine(x*=4);
                    
                }

            }
            catch
            {
                Console.WriteLine("error");
            }

        }
    }
}
