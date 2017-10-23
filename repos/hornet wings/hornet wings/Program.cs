using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hornet_wings
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            decimal m = decimal.Parse(Console.ReadLine());
            int p = int.Parse(Console.ReadLine());

            decimal distance = n / 1000 * m;

            decimal time1 = n / 100 ;
            decimal time2 = (n / p) * 5;

            Console.WriteLine("{0:f2} m.",distance);
            Console.WriteLine("{0} s.", time1+time2);
        }


    }
}
