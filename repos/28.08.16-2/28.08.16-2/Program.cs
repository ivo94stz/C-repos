using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _28._08._16_2
{
    class Program
    {
        static void Main(string[] args)
        {
            var hours = int.Parse(Console.ReadLine());
            var days = int.Parse(Console.ReadLine());
            var add = int.Parse(Console.ReadLine());

            var workhours = days * 0.9 * 8;
            var addhours = add * 2 * days;
            var total = Math.Floor(workhours + addhours);
            var ost = Math.Abs(hours - total);

            if ( hours < total)Console.WriteLine("Yes!{0} hours left.", ost);
            else Console.WriteLine("Not enough time!{0} hours needed.", ost);

        }
    }
}
