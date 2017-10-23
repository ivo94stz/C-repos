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
            int[] arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            List<int> newlist = new List<int>();

            int razlika = 0;
            int bomb = arr[0];
            int times = arr[1];

            for (int i = 0; i < nums.Count; i++)
            {
                if (nums[i] == bomb)
                {
                    if (i + times > nums.Count)
                    {
                        razlika = nums.Count - i-1;
                        nums.RemoveRange(i - times, times + 1);
                        nums.RemoveRange(i - times, razlika);
                        i = 0;
                    }
                    else if (i - times < 0)
                    {
                        razlika = i;
                        nums.RemoveRange(0, razlika + 1);
                        nums.RemoveRange(0, times);
                        i = 0;
                    }
                    else
                    {
                        nums.RemoveRange(i - times, times + 1);
                        nums.RemoveRange(i - times, times);
                        i = 0;
                    }
                }
            }
            int sum = 0;
            for (int i = 0; i < nums.Count; i++)
            {
                sum += nums[i];
            }
            //Console.WriteLine(string.Join(" ", nums));
            Console.WriteLine(sum);
        }
    }
}
