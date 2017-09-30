using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays___tripple_sum
{
    class Program
    {
        static void Main(string[] args)
        {
            var nums = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            var count = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = i+1; j < nums.Length; j++)
                {
                    var sum = nums[i] + nums[j];
                    if(nums.Contains(sum))
                    {
                        Console.WriteLine("{0} + {1} == {2}", nums[i], nums[j], sum);
                        count ++;
                    }

                }
            }
            if (count == 0) Console.WriteLine("No");
        }
    }
}
