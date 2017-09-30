using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18._12._16_2
{
    class Program
    {
        static void Main(string[] args)
        {

            var cash = double.Parse(Console.ReadLine());
            var shir = double.Parse(Console.ReadLine());
            var dulj = double.Parse(Console.ReadLine());
            var a = double.Parse(Console.ReadLine());
            var ha = double.Parse(Console.ReadLine());
            var cena = double.Parse(Console.ReadLine());
            var maistor = double.Parse(Console.ReadLine());

            var Spod = shir * dulj;
            var Spl = a * ha/2;
            var neobh = Math.Ceiling((Spod / Spl + 5));
            var sum = neobh * cena + maistor;
            var ost = Math.Abs(Math.Round(cash - sum,2));

            if (cash > sum) Console.WriteLine("{0:f2} lv left.",ost );
            else Console.WriteLine("You'll need {0:f2} lv more.",ost );
            
        }

    }
}
