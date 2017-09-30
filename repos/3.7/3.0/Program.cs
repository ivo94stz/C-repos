using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._0
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter score: ");
            var num = double.Parse(Console.ReadLine());
            var bonus = 0.0;

            if (num % 2 == 0) bonus += 1;

            else if (num % 10 == 5) bonus += 2;

            if (num <= 100)
            {
                bonus += 5;
                Console.WriteLine("Bonus score: " + bonus);
                Console.WriteLine("Total score: " + (bonus + num));
            }
            else if (num > 100 && num <= 1000)
            {
                bonus += num * 0.2;
                Console.WriteLine("Bonus score: " + bonus);
                Console.WriteLine("Total score: " + (bonus + num));
            }
            else if (num >1000)
            {
                bonus += num * 0.1;
                Console.WriteLine("Bonus score: " + bonus);
                Console.WriteLine("Total score: " + (bonus + num));
            }
            
        }
    }
}
