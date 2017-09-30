using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace izpitna_zadacha_2._2
{
    class Program
    {
        static void Main(string[] args)
        {
            var N = double.Parse(Console.ReadLine());
            var M = double.Parse(Console.ReadLine());
            var Nkg = double.Parse(Console.ReadLine());
            var Mkg = double.Parse(Console.ReadLine());
            
            Console.WriteLine((N * Nkg + M * Mkg) / 1.94); 
        }
    }
}
