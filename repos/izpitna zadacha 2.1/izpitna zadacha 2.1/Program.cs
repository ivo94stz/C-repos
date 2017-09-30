using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace izpitna_zadacha_2._1
{
    class Program
    {
        static void Main(string[] args)
        {
            var w =  double.Parse(Console.ReadLine());
            var h =  double.Parse(Console.ReadLine());
            var rmw = w / 1.2;
            var rmh = (h - 1) / 0.7 ;

            var red = Math.Floor(rmw);
            var kol = Math.Floor(rmh);

            if (h < 3) Console.WriteLine("error");
            else if (h > w) Console.WriteLine("error");
            else if (w > 100) Console.WriteLine("error");
            else Console.WriteLine(red * kol - 3);



        }
    }
}
