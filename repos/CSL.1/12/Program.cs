using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var m = int.Parse(Console.ReadLine());
            var max = int.Parse(Console.ReadLine());

            var sum = 0;
            var count = 0;
            bool ismagic = false;

            for (int i = n; i >=1; i--)
            {
                for (int a = 1; a <= m; a++)
                {
                    if (sum >= max)
                    {
                        ismagic = true;
                        break;
                    }
                    count++;
                    sum += 3 * (i * a);

                }
            }
            Console.WriteLine("{0} combinations", count);
            if (ismagic = true) Console.WriteLine("Sum: {0} >= {1}", sum, max);
            else Console.WriteLine("Sum: {0}",sum);


        }
    }
}
