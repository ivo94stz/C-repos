using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20._11._16_3._3
{
    class Program
    {
        static void Main(string[] args)
        {
            var old = double.Parse(Console.ReadLine());
            var students = double.Parse(Console.ReadLine());
            var nights = double.Parse(Console.ReadLine());
            var transport = (Console.ReadLine());

            var hotel = nights * 82.99;


            if (transport == "train")
            {
                if(old + students >= 50)
                {
                    old = old * 24.99/2;
                    students = students * 14.99/2;
                }
                else
                {
                    old = old * 24.99;
                    students = students * 14.99;

                }

            }
            else if (transport == "bus")
            {
                old = old * 32.5;
                students = students * 28.5;
            }
            else if (transport == "boat")
            {
                old = old * 42.99;
                students = students * 39.99;
            }
            else if (transport == "airplane")
            {
                old = old * 70.0;
                students = students * 50.0;
            }
            var razhod = (old + students) * 2 + hotel;
            var komis = razhod * 0.1;
            var total = razhod + komis;
            Console.WriteLine("{0:f2}", total);
        }
    }
}
