using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];
            

            for (int i = 0; i < n; i++)
            {
                 arr[i]= int.Parse(Console.ReadLine());

            }

            Console.Write(string.Join(" ", arr.Reverse()));
            Console.WriteLine();

        }
        
    }
}
