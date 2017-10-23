using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MDT_6
{
    class Program
    {
        static void Main(string[] args)
        {
            long n = long.Parse(Console.ReadLine());
            Prime(n);
            if (n == 0 || n == 1) Console.WriteLine("false");
        }
        static void Prime(long n)
        {
            if (n >= 2)
            {
                bool prime = true;
                

                    for (long z = 2; z < n; z++)
                    {
                        if (n % z == 0)
                        {
                            prime = false;
                            break;
                        }
                    }

                
                Console.WriteLine(prime);
            }
            
        }
    }
}
