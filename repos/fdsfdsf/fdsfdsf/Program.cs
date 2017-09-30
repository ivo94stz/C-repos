using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fdsfdsf
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            for (int rows = 1; rows <= n / 2; rows++)
            {
                for (int i = 1; i <= 3 * n; i++)
                {
                    if(i <= n / 2)
                    {
                        for (int dot = n/2; dot >= 1; dot--)
                        {
                            Console.Write(".",dot);

                        }
                        Console.WriteLine();
                    }
                    

                }
            }
        }
    }
}
