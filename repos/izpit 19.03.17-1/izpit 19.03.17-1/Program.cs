using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace izpit_19._03._17_1
{
    class Program
    {
        static void Main(string[] args)
        {
            var x = double.Parse(Console.ReadLine());
            var y = double.Parse(Console.ReadLine());
            var h = double.Parse(Console.ReadLine());
            var window = 1.5 * 1.5;
            var door = 1.2 * 2;

            var str = x * y-window;
            var predna = x * x-door;
            var zadna= x* x;
            var green = predna + zadna + 2 * str;
            var greenl = green / 3.4;

            var strp = 2 * x * y;
            var frontp = 2 * (x*h / 2);
            var red = strp + frontp;
            var redl = red / 4.3;

            Console.WriteLine("{0:f2}",greenl );
            Console.WriteLine("{0:f2}", redl);

        }
    }
}
