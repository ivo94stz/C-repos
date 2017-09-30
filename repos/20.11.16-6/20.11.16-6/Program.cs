using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20._11._16_6
{
    class Program
    {
        static void Main(string[] args)
        {
            var num1 = int.Parse(Console.ReadLine());
            var num2 = int.Parse(Console.ReadLine());
            var max = int.Parse(Console.ReadLine());
            var comb = 0;

            var x = num1;
            var y = num2;
            comb = num1;
            while (x <= comb)
            {
                
                
                Console.Write("<{0}-{1}>",x,comb );
                comb++;
                
            }
            
            
        }
    }
}
