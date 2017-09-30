using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7._5
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
                while (x<n-x)
                {
                    Console.WriteLine((x=x*2+1));
                }

                return;
            }
            catch
            {
                Console.WriteLine("error");
            }
        }
    }
}
