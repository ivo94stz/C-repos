using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._4
{
    class Program
    {
        static void Main(string[] args)
        {
            var chislo = double.Parse(Console.ReadLine());
            var chetno = (chislo % 2 == 0);
            var nechetno = (chislo % 2 != 0);

            if (chetno)
            {
                Console.WriteLine("even");
            }
            else 
                {
                Console.WriteLine("odd");
            }
        }
    }
}
