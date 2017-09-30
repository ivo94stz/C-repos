using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace izpit_5._4
{
    class Program
    {
        static void Main(string[] args)
        {
            var money = double.Parse(Console.ReadLine());
            var years = int.Parse(Console.ReadLine());
            var sum = 0.00;
            var x = 19;

            for (int i = 1800; i <= years; i++)
            {
                
                if (i % 2 == 0) money -= 12000;
                else
                {
                    money -= 12000 + 50 * x;
                    x += 2;

                } 

            }
            if (money >= 0) Console.WriteLine("Yes! He will live a carefree life and will have {0:f2} dollars left.", money);
            else if (money < 0) Console.WriteLine("He will need {0:f2} dollars to survive.", Math.Abs(money));
        }
    }
}
