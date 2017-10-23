using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            
            int start = 0;
            int len = 0;
            int max = 0;

            for (int i = 0; i < numbers.Length-1; i++)
            {
                if (numbers[i] == numbers[i+1])
                {
                    len++;
                    if (len > max)
                    {
                        max = len;
                        start = i - len;
                    }
                }
                else
                {
                    len = 0;
                }
                

            }
            for (int i = start+1; i <=start+max+1; i++)
            {
                Console.Write(numbers[i]+" ");
            }
            Console.WriteLine();
        }
    }
}
