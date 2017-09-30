using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace float_or_integer
{
    class Program
    {
        static void Main(string[] args)
        {
            var num = double.Parse(Console.ReadLine());
            
            var x = num % 1;
            var y = num;
            if (x == 0) Console.WriteLine(num);
            else Console.WriteLine(Math.Round(y));


        }
    }
}
