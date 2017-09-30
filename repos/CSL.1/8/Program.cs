using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var total = 0;
            var num = 0;

            while (num < n)
            {
                var ingredients = Console.ReadLine();
                ingredients = ingredients.ToLower();
                if (ingredients == "cheese") total += 500;
                else if (ingredients == "tomato sauce") total += 150;
                else if (ingredients == "salami") total += 600;
                else if (ingredients == "pepper") total += 50;
                num++;

            }
            Console.WriteLine("Total calories: {0}", total);

        }
    }
}
