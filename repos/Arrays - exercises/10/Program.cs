using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int difference = int.Parse(Console.ReadLine());


            int count = 0;
            int diff = 0;

            for (int i = 0; i < numbers.Length; i++)
            {

                for (int j = 0; j < i; j++)
                {
                    diff = Math.Abs( numbers[i] - numbers[j]);
                    if (diff == difference)
                    {
                        count++;

                    }
                    
                }
                
            }
            Console.WriteLine(count);



        }
    }
}
