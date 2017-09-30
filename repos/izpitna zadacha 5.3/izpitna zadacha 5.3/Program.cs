using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace izpitna_zadacha_5._3
{
    class Program
    {
        static void Main(string[] args)
        {
            int years = int.Parse(Console.ReadLine());
            var toys = 0.00;
            var money = 0.00;
            var peralnq = double.Parse(Console.ReadLine());
            var toyprice = double.Parse(Console.ReadLine());
            var x = 0.00;

            for (int i = 1; i <= years ; i++)
            {
                
                if (i % 2 == 0)
                {
                    money += 10;
                    x += money - 1;
                }
                else toys++;

            }
            var sum = toys * toyprice + x;
            var ost = Math.Abs(sum - peralnq);

            if (peralnq < sum) Console.WriteLine("Yes! {0:f2}", ost);
            else Console.WriteLine("No! {0:f2}", ost);

        }
    }
}
