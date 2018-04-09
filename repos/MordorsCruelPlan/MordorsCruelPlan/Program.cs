using System;
using System.Collections.Generic;
using System.Linq;

namespace MordorsCruelPlan
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> input = Console.ReadLine().ToLower().Split().ToList();

            FoodFactory foods = new FoodFactory(input);
            Console.WriteLine(foods.CalculatePoints(input));

            


        }
    }
}
