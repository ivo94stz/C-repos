using System;
using System.Collections.Generic;
using System.Linq;

namespace GenericBox
{
    class Program
    {
        static void Main(string[] args)
        {
            List<double> list = new List<double>();
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                double input =double.Parse( Console.ReadLine());
                list.Add(input);
            }
            double compare =double.Parse( Console.ReadLine());
            Box<double> box = new Box<double>();
            Console.WriteLine(box.GreaterElemnts(list, compare)); 


        }
    }
}
