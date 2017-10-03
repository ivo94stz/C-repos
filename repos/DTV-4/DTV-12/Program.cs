using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTV_12
{
    class Program
    {
        static void Main(string[] args)
        {
            double width = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());
            
            decimal perimeter = (decimal)(width * 2 + height * 2);
            decimal area = (decimal)(width * height);
            decimal diagonal = (decimal)(Math.Sqrt(width*width+height*height));
            Console.WriteLine(perimeter);
            Console.WriteLine(area);
            Console.WriteLine(diagonal);
        }
    }
}
