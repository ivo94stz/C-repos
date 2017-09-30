using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Increment_variable
{
    class Program
    {
        static void Main(string[] args)
        {
            byte x = 0;
            int n = int.Parse(Console.ReadLine());
            int over = 0;

            for (int i = 0; i < n; i++)
            {
                x++;
                if (x == 0) over++;
            }
            Console.WriteLine(x);
            if(over > 0)
            Console.WriteLine("Overflowed {0} times", over );

        }
    }
}
