using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5._7
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var up = 0.00;
            var down = 0.00;
            var sum = 0.00;

            for (int i = 0; i < n   ; i++)
            {
                up = int.Parse(Console.ReadLine());
                down = int.Parse(Console.ReadLine());


            }

            sum = up + down;
            if (up == down)
            {
                Console.WriteLine("Yes, sum = {0}", up);
            }
            else Console.WriteLine("No, diff = {0} ", Math.Abs(up - down));
        }
    }
}
