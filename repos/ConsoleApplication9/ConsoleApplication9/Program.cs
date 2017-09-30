using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication9
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 2;
            int m = 5;
            int res = 1;
            int sum = 0;

            for (int i = 0; i < m; i++)
            {
                res = n * res ;
                sum += res;
            }
            
            Console.WriteLine(res);
            Console.WriteLine(sum);
        }
     }

}
