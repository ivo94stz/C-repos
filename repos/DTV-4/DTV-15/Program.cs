using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTV_15
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            for (int n = 2; n <= num; n++)
            {
                bool even = true;
                for (int z = 2; z < n; z++)
                {
                    if (n % z == 0)
                    {
                        even = false;
                        break;
                    }
                }
                Console.WriteLine($"{n} -> {even}");
            }


        }
    }
}
