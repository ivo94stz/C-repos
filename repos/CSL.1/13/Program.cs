using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13
{
    class Program
    {
        static void Main(string[] args)
        {
            var start = int.Parse(Console.ReadLine());
            var end = int.Parse(Console.ReadLine());
            var magic = int.Parse(Console.ReadLine());

            var lastfirst = 0;
            var lastend = 0;

            int count = 0;

            bool isfound = false;

            for (int a = start; a <= end; a++)
            {
                for (int i = start; i <= end; i++)
                {
                    if (i + a == magic)
                    {
                        lastfirst = i;
                        lastend = a;
                        isfound = true;
                    }
                    count++;
                }
            }
            if (isfound == true)
            {
                Console.WriteLine("Number found! {0} + {1} = {2}", lastend,lastfirst,magic);

            }
            else Console.WriteLine("{0} combinations - neither equals {1}", count,magic);

        }
    }
}
