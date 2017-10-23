using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            int[] arr = new int[nums.Count];
            

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = nums[i];

            }
            string mynum = "";
            int oldnum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                while (arr[i] > 0)
                {
                    oldnum = arr[i] % 10;
                    arr[i] = arr[i] / 10;
                    mynum += oldnum.ToString();

                }
                
                Console.WriteLine(mynum);

            }
        }
    }
}
