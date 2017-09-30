using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20._11._16_1._1
{
    class Program
    {
        static void Main(string[] args)
        {
            var skumriq = double.Parse(Console.ReadLine());
            var caca = double.Parse(Console.ReadLine());
            var palamudkg = double.Parse(Console.ReadLine());
            var safridkg = double.Parse(Console.ReadLine());
            var midikg = double.Parse(Console.ReadLine());

            var palamud = (skumriq + skumriq * 0.6)*palamudkg;
            var safrid = (caca + caca * 0.8)*safridkg;
            var midi = 7.5*midikg;

            var total = palamud + safrid + midi;
            Console.WriteLine("{0:f2}", total);

        }
    }
}
