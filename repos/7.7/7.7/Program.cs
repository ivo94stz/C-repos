﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7._7
{
    class Program
    {
        static void Main(string[] args)
        {
           
                int a = int.Parse(Console.ReadLine());
                int b = int.Parse(Console.ReadLine());

                while (b > 0 )
                {
                    var oa = b;
                    b = a % b;
                    a = oa;

                }
                Console.WriteLine(a);
            
        }
    }
}