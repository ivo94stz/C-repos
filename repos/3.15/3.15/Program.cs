using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._15
{
    class Program
    {
        static void Main(string[] args)
        {
            var figura = Console.ReadLine();
            var data1 = double.Parse(Console.ReadLine());
            var data2 = double.Parse(Console.ReadLine());

            if (figura == "square") Console.WriteLine(Math.Round((data1 * data1), 3));
            else if (figura == "rectangle") Console.WriteLine(Math.Round(data1 * data2),3);
        }
    }
}
