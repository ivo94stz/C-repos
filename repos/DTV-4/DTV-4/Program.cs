﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTV_4
{
    class Program
    {
        static void Main(string[] args)
        {
            string var = Console.ReadLine();
            bool output = Convert.ToBoolean(var);
            if (output == true) Console.WriteLine("Yes");
            else Console.WriteLine("No");

        }
    }
}
