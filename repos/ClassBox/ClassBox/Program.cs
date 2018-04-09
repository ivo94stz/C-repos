﻿using System;

namespace ClassBox
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                double length = double.Parse(Console.ReadLine());
                double width = double.Parse(Console.ReadLine());
                double height = double.Parse(Console.ReadLine());

                var box = new Box(length, width, height);
                Console.WriteLine($"Surface Area - {box.SurvfaceArea():f2}");
                Console.WriteLine($"Lateral Surface Area - {box.LeterealSurfaceArea():f2}");
                Console.WriteLine($"Volume - {box.Volume():f2}");
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
    }
}
