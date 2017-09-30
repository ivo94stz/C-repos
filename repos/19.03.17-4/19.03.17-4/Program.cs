using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19._03._17_4
{
    class Program
    {
        static void Main(string[] args)
        {
            var lekcii = double.Parse(Console.ReadLine());
            var budget = double.Parse(Console.ReadLine());
            var jelev = 0;
            var royal = 0;
            var roli = 0;
            var trofon = 0;
            var sino = 0;
            var others = 0;
            var one = budget / lekcii;

            for (int i = 0; i < lekcii; i++)
            {
                var name = Console.ReadLine();

                if(name == "Jelev") jelev++;
                else if (name == "RoYaL") royal++;
                else if (name == "Roli") roli++;
                else if (name == "Trofon") trofon++;
                else if (name == "Sino") sino++;
                else   others++;
            }
            Console.WriteLine("Jelev salary: {0:f2} lv", one*jelev);
            Console.WriteLine("RoYaL salary: {0:f2} lv", one * royal);
            Console.WriteLine("Roli salary: {0:f2} lv", one * roli);
            Console.WriteLine("Trofon salary: {0:f2} lv", one * trofon);
            Console.WriteLine("Sino salary: {0:f2} lv", one * sino);
            Console.WriteLine("Others salary: {0:f2} lv", one * others);




        }
    }
}
