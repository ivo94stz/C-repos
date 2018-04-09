using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var queue = new Queue<long>();
            var result = new Queue<long>();
            queue.Enqueue(n);
            result.Enqueue(n);

            while (result.Count < 50)
            {
                queue.Enqueue(n + 1);
                if (result.Count == 50) break;
                queue.Enqueue(2 * n + 1);
                if (result.Count == 50) break;
                queue.Enqueue(n + 2);
                if (result.Count == 50) break;
                result.Enqueue(n + 1);
                if (result.Count == 50) break;
                result.Enqueue(2 * n + 1);
                if (result.Count == 50) break;
                result.Enqueue(n + 2);
                if (result.Count == 50) break;
                n = queue.Dequeue();
            }
            foreach (var item in result)
            {
                Console.Write("{0} ",item);
            }





        }
    }
}
