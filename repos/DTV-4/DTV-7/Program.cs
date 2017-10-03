using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTV_7
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());

            int olda = b;
            int oldb = a;

            Console.WriteLine("Before:\r\na = {0}\r\nb = {1}\r\nAfter:\r\na = {2}\r\nb = {3}",a,b,olda,oldb);

        }
    }
}
