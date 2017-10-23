using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());

            long[] arr = new long[n];
            arr[0] = 1;
            long sum = 0;

            for (int i = 1; i < n; i++)
            {
                for (int j = i-k; j <= i-1; j++)
                {
                    if (j >= 0) sum = sum + arr[j];
                }
                arr[i] = sum;

            }
            for (int i = 0; i < n; i++)
            {
                Console.Write(arr[i]+" ");
            }

        }
    }
}
