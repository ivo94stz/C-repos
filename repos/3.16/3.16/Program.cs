using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._16
{
    class Program
    {
        static void Main(string[] args)
        {
            var chas = double.Parse(Console.ReadLine());
            var min = double.Parse(Console.ReadLine());
            var add = 15.0;

            Console.WriteLine(string.Format(@"{0:hh\:mm}-{1:hh\mm}", chas, min));
        }
    }
}
