using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5
{
    class Program
    {
        static void Main(string[] args)
        {
            List<decimal> nums = Console.ReadLine().Split(' ').Select(decimal.Parse).ToList();

            //decimal temp = 0;
            //for (int i = 0; i < nums.Count-1; i++)
            //{
            //    temp = nums[i];
            //    if (nums[i] > nums[i + 1])
            //    {

            //        nums[i] = nums[i + 1];
            //        nums[i + 1] = temp;
            //        i=-1;

            //    }



            //}
            //Console.WriteLine(string.Join("<=",nums));

            nums.Sort();
            Console.WriteLine(string.Join("<=", nums));

        }
    }
}
