using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16
{
    class Program
    {
        static void Main(string[] args)
        {
            List<double> nums = Console.ReadLine().Split(' ').Select(double
                .Parse).ToList();
            var squares = new List<double>();


            foreach (var num in nums)
            {

                if (Math.Sqrt(num) % 1 == 0)
                {
                    squares.Add(num);
                }

                    
            }
            squares.Sort();
            squares.Reverse();
            Console.WriteLine(string.Join(" ",squares));
                




        }
    }
}
