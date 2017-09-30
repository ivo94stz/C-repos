using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Refactor_volume_of_pyramid
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Length: ");
            double dul = double.Parse(Console.ReadLine());
            Console.Write("Width: ");
            double sh = double.Parse(Console.ReadLine());
            Console.Write("Height: ");
            double v = double.Parse(Console.ReadLine());

            double ve = 0;
            ve = (dul * sh * v) / 3;
            Console.WriteLine("Pyramid Volume: {0:f2}", ve);

        }
    }
}
