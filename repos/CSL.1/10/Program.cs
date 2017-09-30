using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                for (int x = i; x <= i; x++)
                {
                    
                    for (int z = 0; z < x; z++)
                    {
                        Console.Write("{0} ",i);
                    }
                }
                Console.WriteLine();
            }


        }
    }
}
