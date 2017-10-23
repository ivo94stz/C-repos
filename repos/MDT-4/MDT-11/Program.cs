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
            
            var figuries = Console.ReadLine();

            if(figuries == "triangle"|| figuries == "rectangle")
            {
                double side1 = double.Parse(Console.ReadLine());
                double side2 = double.Parse(Console.ReadLine());
                TwoSides(figuries, side1, side2);
            }
            else if (figuries == "square" || figuries == "circle")
            {
                double side1 = double.Parse(Console.ReadLine());
                OneSide(figuries, side1);
            }
            

        }
        static void TwoSides(string figuries, double side1, double side2)
        {
            double area = 0;
            if (figuries == "triangle")
            {
                area = side1*side2/2;
            }
            
            else if (figuries == "rectangle")
            {
                area = side1*side2;
            }
            

            Console.WriteLine("{0:f2}", area);
        }
        static void OneSide(string figuries, double side1)
        {
            double area = 0;
            if (figuries == "square")
            {
                area = side1*side1;
            }
            else if (figuries == "circle")
            {
                area = Math.PI * side1 * side1;

            }
            Console.WriteLine("{0:f2}", area);
        }
    }
}
