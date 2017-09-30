﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arrays___2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var primes = new bool[n + 1];
            for (int i = 2; i <=n; i++)
            {
                primes[i] = true;
            }

            for (int num = 2; num<=n; num++)
            {
                if (primes[num])
                {
                    Console.WriteLine(num);
                    var p = 2 * num;
                    while (p <= n)
                    {
                        primes[p] = false;
                        p = p + num;
                    }
                }
            }



        }
    }
}
