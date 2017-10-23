using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lists_lab
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> nums = Console.ReadLine().Split(' ').ToList();

            List<int> newlist = new List<int>();
            for (int i = 0; i < nums.Count; i++)
            {
                newlist.Add(int.Parse(nums[i]));

               
            }
            int count = newlist.Count;
            for (int i = newlist.Count-1; i >= 0; i--)
            {
                if (newlist[i] < 0)
                {
                    newlist.Remove(newlist[i]);
                    count--;
                }
                
            }
            if (count == 0) Console.WriteLine("empty");
            else
            {
                newlist.Reverse();
                Console.WriteLine(string.Join(" ",newlist));
            }

        }
    }
}
