﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication11
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            Console.WriteLine(new string('*', n));
            for (int row = 0; row < n-2; row++)
            {
                for (int i = 0; i < row; i++)
                {
                    Console.Write("/");
                }
                Console.Write("*");
                for (int i = 0; i < row; i++)
                {
                    Console.Write(new string(' ', n - 2));
                    Console.WriteLine("*");
                }
                
            }
            Console.WriteLine(new string('*', n));
        }
    }
}
