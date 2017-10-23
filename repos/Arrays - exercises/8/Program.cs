using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8
{
    class Program
    {
        static void Main(string[] args)
        {
            ushort[] nums = Console.ReadLine().Split(' ').Select(ushort.Parse).ToArray();

            ushort max = 0;
            ushort bestmax = 0;
            
            ushort output = 0;
            for (int i = 0; i < nums.Length; i++)
            {

                for (int j = nums.Length-1; j > i; j--)
                {
                    if (nums[i] == nums[j])
                    {
                        max++;
                        if (max > bestmax)
                        {
                            bestmax = max;
                            output = nums[i];
                        }
                    }
                    
                }
                max = 0;
            }
            Console.WriteLine(output);

        }
    }
}
