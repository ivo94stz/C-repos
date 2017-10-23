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
            List<int> nums = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            int[] arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            List<int> newlist = new List<int>();
            int delete = 0;

            for (int i = 1; i <= nums.Count + 1; i++)
            {
                if (i - 1 < arr[0])
                {
                    newlist.Add(nums[i - 1]);

                }

            }
            //Console.WriteLine(string.Join(" ",newlist));
            for (int i = 1; i <= arr[1]; i++)
            {
                newlist.RemoveAt(0);
                
            }

            //Console.WriteLine(string.Join(" ", newlist));

            if (newlist.Contains(arr[2]))
            {
                Console.WriteLine("YES!");

            }
            else Console.WriteLine("NO!");
        }
    }
}

