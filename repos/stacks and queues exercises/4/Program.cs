using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] ints = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            var queue = new Queue<int>();
            int[] nums = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int count = 0;

            while (queue.Count < ints[0])
            {
                queue.Enqueue(nums[count]);
                count++;
            }

            for (int i = 0; i < ints[1]; i++)
            {
                queue.Dequeue();
            }
            if (queue.Contains(ints[2])) Console.WriteLine("true");
            else if (queue.Count == 0) Console.WriteLine("0");
            else Console.WriteLine(queue.Min());


        }
    }
}
