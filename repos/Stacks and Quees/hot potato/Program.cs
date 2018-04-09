using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hot_potato
{
    class Program
    {
        static void Main(string[] args)
        {
            var kids = Console.ReadLine().Split(' ');
            var toss = int.Parse(Console.ReadLine());
            var queue = new Queue<string>(kids);
            while (queue.Count != 1)
            {
                for (int i = 1; i < toss; i++)
                {
                    queue.Enqueue(queue.Dequeue());

                }
                Console.WriteLine("Removed {0}",queue.Dequeue());
            }
            Console.WriteLine("Last is {0}",queue.Dequeue());
        }
    }
}
