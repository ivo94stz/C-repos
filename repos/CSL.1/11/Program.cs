using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = int.Parse(Console.ReadLine());
            var b = int.Parse(Console.ReadLine());

            if (b - a < 5) Console.WriteLine("No");
            else
            {
                for (int x = a; x <= b; x++)
                {
                    for (int y = a; y <= b; y++)
                    {
                        for (int z = a; z <= b; z++)
                        {
                            for (int q = a; q <= b; q++)
                            {
                                for (int h = a; h <= b; h++)
                                {
                                    if (y <= x || z <= y || q <= z || h <= q) continue;
                                    else
                                    {
                                        Console.Write(x+" ");
                                        Console.Write(y + " ");
                                        Console.Write(z+" ");
                                        Console.Write(q+" ");
                                        Console.WriteLine(h);
                                        
                                    }
                                }
                            }
                        }
                    }
                }


            }


        }
    }
}
