using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20._11._16_2._2
{
    class Program
    {
        static void Main(string[] args)
        {
            var days = double.Parse(Console.ReadLine());
            var footkg = double.Parse(Console.ReadLine());
            var dog = double.Parse(Console.ReadLine());
            var cat = double.Parse(Console.ReadLine());
            var kost = double.Parse(Console.ReadLine());

            var total = days * dog + days * cat + days*kost/1000;
            var ost = Math.Abs(total - footkg);

            if (total - footkg >= 0) Console.WriteLine("{0} more kilos of food are needed.", Math.Ceiling(ost));
            else Console.WriteLine("{0} kilos of food left.",Math.Floor(ost));
        }
    }
}
