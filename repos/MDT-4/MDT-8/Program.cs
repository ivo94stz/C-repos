using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MDT_8
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1 = int.Parse(Console.ReadLine());
            int n2= int.Parse(Console.ReadLine());
            int n3 = int.Parse(Console.ReadLine());
            int n4 = int.Parse(Console.ReadLine());

            int a1 = 0;
            int b1 = 0;

            if (n1 - n2 < n2 - n1)
            {
                 a1 = n1;
            }
            else
            {
                 a1 = n2;
            }
            if (n3 - n4 < n4 - n3)
            {
                 b1 = n3;
            }
            else
            {
                 b1 = n4;
            }
            XY(a1, b1);

        }
        static void XY(int a1, int b1)
        {

            
            Console.WriteLine("({0}, {1})",b1,a1);
        }
    }
}
