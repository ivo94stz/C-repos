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
            List<int> nums = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            nums.Sort();

            int start = 0;
            int len = 1;

            for (int i = 0; i <= nums.Count; i++)
            {
                if (nums[i] != nums[i + 1]||i==nums.Count-1)
                {
                    Console.WriteLine("{0} -> {1}", nums[start], len);
                    len=1;
                    start = i + 1;
                }
                else
                {
                    len  ++;
                }
                
                
            }
           
        }
    }
}
