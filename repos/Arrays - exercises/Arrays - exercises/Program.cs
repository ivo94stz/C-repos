using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays___exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arr1 = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            string[] arr2 = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            int left = maxEqualWords(arr1, arr2);
            Array.Reverse(arr1);
            Array.Reverse(arr2);
            int right = maxEqualWords(arr1, arr2);
            Console.WriteLine(Math.Max(left,right));
        }
        static int maxEqualWords(string[] arr1,string[] arr2)
        {
            int lenght = Math.Min(arr1.Length
                , arr2.Length);
            int count = 0;
            for (int i = 0; i < lenght; i++)
            {
                if (arr1[i] == arr2[i])
                {
                    count++;
                }
                else break;
            }
            return count;
        }
    }
}
