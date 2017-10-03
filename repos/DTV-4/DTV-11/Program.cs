using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTV_11
{
    class Program
    {
        static void Main(string[] args)
        {
            int metres = int.Parse(Console.ReadLine());
            int hours = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());
            int seconds = int.Parse(Console.ReadLine());

            float mps = (float)(metres / seconds);
            float kmph = (float)(metres / 1000 / hours);
            float mpph = (float)(metres / 1609 / hours);

            Console.WriteLine("{0:f6}\r\n{1:f6}\r\n{2:f6}",mps,kmph,mpph);



        }
    }
}
