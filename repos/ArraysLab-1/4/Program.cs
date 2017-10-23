using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4
{
    class Program
    {
        static void Main(string[] args)
        {
            var arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int sum = 0;
            int count = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i+1; j < arr.Length; j++)
                {
                    sum = arr[i] + arr[j];
                    if (arr.Contains(sum))
                    {
                        Console.WriteLine("{0} + {1} == {2}",arr[i],arr[j],sum);
                        count++;
                    }

                }
            }
            if (count == 0) Console.WriteLine("No");
        }
    }
}
