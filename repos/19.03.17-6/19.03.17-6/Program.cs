using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19._03._17_6
{
    class Program
    {
        static void Main(string[] args)
        {
            var end = int.Parse(Console.ReadLine());
            var start = int.Parse(Console.ReadLine());
            var magic = int.Parse(Console.ReadLine());
            var comb = 0;
            var z = 0;
            var y = 0;


            for (int i = end; i >=start ; i--)
            {
                for (int x = end; x >= start; x--)
                {
                    comb++;
                    //Console.WriteLine(comb);
                    if (i + x == magic)
                    {
                        Console.WriteLine("Combination N:{0} ({1} + {2} = {3})", comb, i, x, magic);
                        i = start;
                        break;
                    }
                    
                }


            }
            if(start>=magic && end>= magic) Console.WriteLine("{0} combinations - neither equals {1}", comb, magic);
            else if(end*2<magic) Console.WriteLine("{0} combinations - neither equals {1}", comb, magic);
            else if(2*start >magic) Console.WriteLine("{0} combinations - neither equals {1}", comb, magic);




        }
    }
}
