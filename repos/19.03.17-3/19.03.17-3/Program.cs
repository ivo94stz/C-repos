using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19._03._17_3
{
    class Program
    {
        static void Main(string[] args)
        {
            var budget = double.Parse(Console.ReadLine());
            var season = Console.ReadLine();

            if (budget <= 1000)
            {

                if (season == "Summer")
                {
                    budget = budget * 0.65;
                    Console.WriteLine("Alaska - Camp - {0:f2}",budget);
                } 
                else if(season == "Winter")
                {
                    budget = budget * 0.45;
                    Console.WriteLine("Morocco - Camp - {0:f2}", budget);
                }
            }
            else if(budget>1000 && budget <= 3000)
            {
                if(season == "Summer")
                {
                    budget = budget * 0.8;
                    Console.WriteLine("Alaska - Hut - {0:f2}", budget);
                }
                else if(season == "Winter")
                {
                    budget = budget * 0.6;
                    Console.WriteLine("Morocco - Hut - {0:f2}", budget);
                }

            }
            else if (budget > 3000)
            {
                budget = budget * 0.9;
                if (season == "Summer") Console.WriteLine("Alaska - Hotel - {0:f2}", budget);
                else if(season== "Winter") Console.WriteLine("Morocco - Hotel - {0:f2}", budget);
            }




        }
    }
}
