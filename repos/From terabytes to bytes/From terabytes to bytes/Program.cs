using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace From_terabytes_to_bytes
{
    class Program
    {
        static void Main(string[] args)
        {
            double tb = double.Parse(Console.ReadLine());
            long bits = (long)(tb * 1024 * 1024 * 1024 * 1024 * 8);
            Console.WriteLine(bits);
            

        }
    }
}
