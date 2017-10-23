using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MDT_9
{
    class Program
    {
        static void Main(string[] args)
        {
            double side = double.Parse(Console.ReadLine());
            var parameter = Console.ReadLine();
            Cube(side, parameter);

        }
        static void Cube(double side, string parameter)
        {
            double face = 0;
            if (parameter == "face")
            {
                 face = Math.Sqrt(2 * side * side);
            }
            else if (parameter == "space")
            {
                face = Math.Sqrt(3 * side * side);
            }
            else if (parameter == "volume")
            {
                 face = (side * side * side);
            }
            else if (parameter == "area")
            {
                face = (6 * side * side);
            }

            Console.WriteLine("{0:f2}",face);
        }
    }
}
