using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _28._08._16_6
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var red = n / 100 + n / 10 % 10;
            var kol = n / 100 + n % 10;
            var fd = n / 100;
            var sd = n / 10 % 10;
            var td = n % 10;
            var num = 0;


            for (int row = 0; row < red; row++)
            {
                for (int col = 0; col < kol; col++)
                {
                    if (n % 5 == 0)
                    {
                        num = n - fd;
                        n = num;
                    }
                    else if (n % 3 == 0)
                    {
                        num = n - sd;
                        n = num;
                    }
                    else
                    {
                        num = n + td;
                        n = num;
                    } 
                    Console.Write("{0} ",num);
                }

                Console.WriteLine();
            }

            
        }
    }
}
