using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9
{
    class Program
    {
        static void Main(string[] args)
        {
            var sum = 0;

            try
            {
                while (true)
                {
                    var input = int.Parse(Console.ReadLine());
                    sum++;

                }
            }
            catch(Exception)
            {
                Console.WriteLine(sum);
            }
            



        }
    }
}
