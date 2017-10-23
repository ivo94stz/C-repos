using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> nums = Console.ReadLine().Split('|').ToList();
            nums.Reverse();

            var result = new List<string>();
            foreach (var  num in nums)
            {
                List<string> items = num.Split(new char[] { ' ' },StringSplitOptions.RemoveEmptyEntries).ToList();
                result.AddRange(items);
            }
            Console.WriteLine(string.Join(" ",result));
            

            


        }
    }
}
