using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MDT_5
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Fib(n);

        }
        static void Fib(int n)
        {
            var ff = 1;
            var fs = 1;
            for (int i = 1; i <= n - 1; i++)
            {
                var x = ff + fs;
                ff = fs;
                fs = x;
            }
            Console.WriteLine(fs);


        }
    }
}
