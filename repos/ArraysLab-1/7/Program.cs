using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr1 = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int[] arr2 = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            if (arr1.Length <= arr2.Length)
            {
                int sum = arr2.Length;
                for (int i = 0; i < arr2.Length; i++)
                {
                    sum = arr1[i % arr1.Length] + arr2[i];
                    if (i > arr2.Length) break;

                    Console.Write(sum + " ");
                }
                
            }
            else if (arr1.Length >= arr2.Length)
            {
                int sum = arr1.Length;
                for (int i = 0; i < arr1.Length; i++)
                {
                    sum = arr1[i ] + arr2[i%arr2.Length];
                    if (i > arr1.Length) break;

                    Console.Write(sum + " ");
                }
                
            }

            Console.WriteLine();




        }
    }
}
