using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18._12
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = double.Parse(Console.ReadLine());
            var top = 0.0;
            var four = 0.0;
            var three = 0.0;
            var two = 0.0;
            var total = 0.0;

            for (int i = 0; i < n; i++)
            {
                var ocenka = double.Parse(Console.ReadLine());
                
                if (ocenka >= 5) top++;
                else if (ocenka >= 4&& ocenka<5) four++;
                else if (ocenka >= 3 && ocenka<4) three++;
                else if (ocenka >= 2 && ocenka<3) two++;
                total = (total + ocenka);
            }
            var newtop = top / n * 100;
            var newfour = four / n * 100;
            var newthree = three / n * 100;
            var newtwo = two / n * 100;
            Console.WriteLine("Top students: {0:f2}%",newtop);
            Console.WriteLine("Between 4.00 and 4.99: {0:f2}%", newfour);
            Console.WriteLine("Between 3.00 and 3.99: {0:f2}%", newthree);
            Console.WriteLine("Fail: {0:f2}%", newtwo);
            Console.WriteLine("Average: {0:f2}", total/n);

        }
    }
}
