using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4._9
{
    class Program
    {
        static void Main(string[] args)
        {
            var day = double.Parse(Console.ReadLine());

            if (day == 1.0) Console.WriteLine("Monday");
            else if (day == 2.0) Console.WriteLine("Tuesday");
            else if (day == 3.0) Console.WriteLine("Wednesday");
            else if (day == 4.0) Console.WriteLine("Thursday");
            else if (day == 5.0) Console.WriteLine("Friday");
            else if (day == 6.0) Console.WriteLine("Saturday");
            else if (day == 7.0) Console.WriteLine("Sunday");
            else  Console.WriteLine("Error");
        }
    }
}
