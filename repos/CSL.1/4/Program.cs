using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4
{
    class Program
    {
        static void Main(string[] args)
        {
            var month = Console.ReadLine();
            var nights = double.Parse(Console.ReadLine());


            if(nights>0&&nights<200)
            {
                if (month == "May" || month == "October")
                {
                    var studio = 50.0 * nights;
                    if (nights > 7)
                    {
                        studio = studio * 0.95;
                    }
                    if (month == "October" && nights > 7) studio = studio - 50;
                    var doublee = 65.0 * nights;
                    var suite = 75.0 * nights;
                    Console.WriteLine("Studio: {0:f2} lv.", studio);
                    Console.WriteLine("Double: {0:f2} lv.", doublee);
                    Console.WriteLine("Suite: {0:f2} lv.", suite);

                }


                else if (month == "June" || month == "September")
                {
                    var studio = 60.0 * nights;
                    if (month == "September") studio = studio - 60;
                    var doublee = 72.0 * nights;
                    if (nights > 14)
                    {
                        doublee = doublee * 0.9;
                    }

                    var suite = 82.0 * nights;
                    Console.WriteLine("Studio: {0:f2} lv.", studio);
                    Console.WriteLine("Double: {0:f2} lv.", doublee);
                    Console.WriteLine("Suite: {0:f2} lv.", suite);
                }


                else if (month == "July" || month == "August" || month == "December")
                {
                    var studio = 68.0 * nights;
                    var doublee = 77.0 * nights;


                    var suite = 89.0 * nights;
                    if (nights > 14) suite = suite * 0.85;
                    Console.WriteLine("Studio: {0:f2} lv.", studio);
                    Console.WriteLine("Double: {0:f2} lv.", doublee);
                    Console.WriteLine("Suite: {0:f2} lv.", suite);
                }
            }



            


        }
    }
}
