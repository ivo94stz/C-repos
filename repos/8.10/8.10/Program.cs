using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8._10
{
    class Program
    {
        static void Main(string[] args)
        {
            var n =Math.Abs( -34326543);
            while (n >= 1000)
                n = n / 10;
            Console.WriteLine(n);
        }
    }
}
