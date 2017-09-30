using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8._7
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = int.Parse(Console.ReadLine());
            var b = int.Parse(Console.ReadLine());
            while(b!=0)
            {
                var x = b;
                b = a % b;
                a = x;
            }
            Console.WriteLine(a);
        }
    }
}
