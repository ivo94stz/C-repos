using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14
{
    class Program
    {
        static void Main(string[] args)
        {
            var first = char.Parse(Console.ReadLine());
            var second = char.Parse(Console.ReadLine());
            var skip = char.Parse(Console.ReadLine());

            string result = "";

            for (char i = first; i <= second; i++)
            {
                for (char x = first; x <= second; x++)
                {
                    for (char z = first; z <= second; z++)
                    {
                        string current = "" + i + x + z;
                        if (!current.Contains(skip + ""))
                        {
                            Console.Write(current+" ");
                        }
                    }
                }
            }


        }
    }
}
