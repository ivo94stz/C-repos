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
            int[] ints = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            var stack = new Stack<int>();
            int[] nums = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int count = 0;

            while (stack.Count < ints[0])
            {
                stack.Push(nums[count]);
                count++;
            }
           
            for (int i = 0; i < ints[1]; i++)
            {
                stack.Pop();
            }
            if (stack.Contains(ints[2])) Console.WriteLine("true");
            else if (stack.Count == 0) Console.WriteLine("0");
            else Console.WriteLine(stack.Min());

            


        }
    }
}
