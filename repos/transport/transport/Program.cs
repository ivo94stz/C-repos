using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace transport
{
    class Program
    {
        static void Main(string[] args)
        {
            double n = double.Parse(Console.ReadLine());

            var capacity = 24;
            var courses = Math.Ceiling(n / capacity);
            Console.WriteLine($"{courses}");


        }
    }
}
