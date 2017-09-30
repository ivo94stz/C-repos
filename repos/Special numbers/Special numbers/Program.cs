using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Special_numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            
            int x = 0;
            

            for (int i = 1; i <= n; i++)
            {
                int sum1 = 0;
                x = i;
                
                while (x > 0)
                {
                    sum1 += x % 10;
                    x = x / 10;
                }
                if (sum1 == 5 || sum1 == 7 || sum1 == 11) Console.WriteLine("{0} -> True", i);
                else Console.WriteLine("{0} -> False", i);
                
            }
            


        }
    }
}
