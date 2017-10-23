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

            int[] nums = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int count = 0;
            int start = 0;
            int max = 0;

            for (int i = 0; i < nums.Length-1; i++)    
            {
                if (nums[i+1]-nums[i]==1)
                {
                    count++;
                    if (count > max)
                    {
                        max = count;
                        start = i - count;
                    }
                    else
                    {
                        count = 0;
                    }
                }


            }
            for (int i =start; i < start +max+1; i++)
            {
                Console.Write(nums[i]+" ");
            }
            Console.WriteLine();


        }
    }
}
