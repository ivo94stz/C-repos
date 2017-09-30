using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace izpit_1._1
{
    class Program
    {
        static void Main(string[] args)
        {
            var bitcoin = double.Parse(Console.ReadLine());
            var uan = double.Parse(Console.ReadLine());
            var comission = double.Parse(Console.ReadLine());
            var lvuan = uan * 0.15 * 1.76;
            var lvbitcoin = bitcoin * 1168;

            Console.WriteLine((lvbitcoin / 1.95 + lvuan / 1.95) - (lvbitcoin / 1.95 + lvuan / 1.95) * comission / 100);

        }
    }
}
