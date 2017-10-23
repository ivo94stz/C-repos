using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lists_exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            
            int len = 1;
            
            int bestslen = 0;
            int number = 0;

            for (int i = 0; i < nums.Count-1; i++)
            {

                if (nums[i] == nums[i + 1])
                {
                    len++;

                }
                else
                {
                    len = 1;

                }
                
                if (len > bestslen)
                {
                    bestslen = len;
                    number = nums[i];
                }

                
            }
            int[] arr = new int[bestslen];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = number;
            }

           

            Console.WriteLine(string.Join(" ",arr));
        }
    }
}
