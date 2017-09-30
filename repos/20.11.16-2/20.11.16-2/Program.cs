using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20._11._16_2
{
    class Program
    {
        static void Main(string[] args)
        {
            var magn = double.Parse(Console.ReadLine());
            var zyumb = double.Parse(Console.ReadLine());
            var rose =double.Parse(Console.ReadLine());
            var kaktus =double.Parse(Console.ReadLine());
            var gift = double.Parse(Console.ReadLine());

            var buket = magn * 3.25 + zyumb * 4 + rose * 3.5 + kaktus * 8;
            var total = buket - buket * 0.05;
            var ost1 = Math.Floor(total - gift);
            var ost2 = Math.Abs(Math.Floor(total - gift));

            if (total >= gift) Console.WriteLine("She is left with {0} leva.",ost2);
            else Console.WriteLine("She will have to borrow {0} leva.", ost2 );
        }
    }
}
