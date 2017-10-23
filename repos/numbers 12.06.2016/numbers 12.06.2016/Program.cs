using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace numbers_12._06._2016
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            if (nums.Length < 5) Console.WriteLine("No");
            else
            {
                List<int> newnums = new List<int>();

                double average = 0;

                for (int i = 0; i < nums.Length; i++)
                {
                    average += nums[i];
                }
                average /= nums.Length;

                for (int i = 0; i < nums.Length; i++)
                {
                    if (nums[i] > average) newnums.Add(nums[i]);
                }
                newnums.Sort();
                newnums.Reverse();
                Console.WriteLine(string.Join(" ", newnums.Take(5)));

            }


        }
    }
}
