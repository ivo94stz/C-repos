﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._5
{
    class Program
    {
        static void Main(string[] args)
        {
            var chislo1 = int.Parse(Console.ReadLine());
            var chislo2 = int.Parse(Console.ReadLine());
            if (chislo1 > chislo2)
            {
                Console.WriteLine(chislo1);
            }
            else
            {
                Console.WriteLine(chislo2);
            }
        }
    }
}
