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
            var nums = Console.ReadLine().Split(' ').Select(decimal.Parse).ToList();
            decimal sum = 0;
            List<decimal> result = new List<decimal>(); 

            for (int i = 1; i < nums.Count; i++)
            {
                if (nums[i] == nums[i - 1])
                {
                    nums[i - 1] += nums[i];
                    nums.RemoveAt(i);
                    i-=2;
                    if (i < 0) i = 0;

                }
                
                result.Add(sum);



            }
            Console.WriteLine(string.Join(" ",nums));


        }
    }
}
