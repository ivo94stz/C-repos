using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sweet_desert
{
    class Program
    {
        static void Main(string[] args)
        {
            double cash = double.Parse(Console.ReadLine());
            double guests = double.Parse(Console.ReadLine());
            double bananas = double.Parse(Console.ReadLine());
            double eggs = double.Parse(Console.ReadLine());
            double berries = double.Parse(Console.ReadLine());

            guests = (double)Math.Ceiling(guests / 6);


            double totalbananas = guests * 2 * bananas;
            double totaleggs = guests * 4 * eggs;
            double totalberries = guests * berries * 0.2;
            double total = totalbananas + totalberries + totaleggs;
            if (total <= cash) Console.WriteLine("Ivancho has enough money - it would cost {0:f2}lv.",total);
            else Console.WriteLine("Ivancho will have to withdraw money - he will need {0:f2}lv more.",total-cash);

            
            


        }
    }
}
