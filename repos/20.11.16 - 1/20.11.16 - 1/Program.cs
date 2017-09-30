using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20._11._16___1
{
    class Program
    {
        static void Main(string[] args)
        {
            var mini = double.Parse(Console.ReadLine());
            var kitchen = double.Parse(Console.ReadLine());
            var price = double.Parse(Console.ReadLine());

            var bath = mini / 2.0;
            var sec = mini * 1.1;
            var third = sec * 1.1;
            var total = mini + kitchen + bath + sec + third;
            var all = total + 0.05 * total;
            var totalprice = all * price;
            Console.WriteLine("{0:f2} ", totalprice);
        }
    }
}
