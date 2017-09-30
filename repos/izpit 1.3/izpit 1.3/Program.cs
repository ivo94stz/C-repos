using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace izpit_1._3
{
    class Program
    {
        static void Main(string[] args)
        {
            var budget = double.Parse(Console.ReadLine());
            var category = Console.ReadLine();
            var group = double.Parse(Console.ReadLine());
            var normal = 249.99;
            var vip = 499.99;

            if (group >= 1 && group <= 4)
            {
                var ost1 = budget - budget * 0.75;
                if (category == "Normal")
                {
                    var left1 = ost1 - normal * group;
                    if (left1 > 0) Console.WriteLine("Yes! You have {0:f2} leva left.", Math.Abs(left1));
                    else Console.WriteLine("Not enough money! You need {0:f2} leva.", Math.Abs(left1));
                }
                else if (category == "VIP")
                {
                    var left1 = ost1 - vip * group;
                    if (left1 > 0) Console.WriteLine("Yes! You have {0:f2} leva left.", Math.Abs(left1));
                    else Console.WriteLine("Not enough money! You need {0:f2} leva.", Math.Abs(left1));
                }
            }
            if (group >5 && group <=9 )
            {
                var ost1 = budget - budget * 0.60;
                if (category == "Normal")
                {
                    var left1 = ost1 - normal * group;
                    if (left1 > 0) Console.WriteLine("Yes! You have {0:f2} leva left.", Math.Abs(left1));
                    else Console.WriteLine("Not enough money! You need {0:f2} leva.", Math.Abs(left1));
                }
                else if (category == "VIP")
                {
                    var left1 = ost1 - vip * group;
                    if (left1 > 0) Console.WriteLine("Yes! You have {0:f2} leva left.", Math.Abs(left1));
                    else Console.WriteLine("Not enough money! You need {0:f2} leva.", Math.Abs(left1));
                }
            }
            if (group >= 10 && group <= 24)
            {
                var ost1 = budget - budget * 0.50;
                if (category == "Normal")
                {
                    var left1 = ost1 - normal * group;
                    if (left1 > 0) Console.WriteLine("Yes! You have {0:f2} leva left.", Math.Abs(left1));
                    else Console.WriteLine("Not enough money! You need {0:f2} leva.", Math.Abs(left1));
                }
                else if (category == "VIP")
                {
                    var left1 = ost1 - vip * group;
                    if (left1 > 0) Console.WriteLine("Yes! You have {0:f2} leva left.", Math.Abs(left1));
                    else Console.WriteLine("Not enough money! You need {0:f2} leva.", Math.Abs(left1));
                }
            }
            if (group >= 25 && group <= 49)
            {
                var ost1 = budget - budget * 0.40;
                if (category == "Normal")
                {
                    var left1 = ost1 - normal * group;
                    if (left1 > 0) Console.WriteLine("Yes! You have {0:f2} leva left.", Math.Abs(left1));
                    else Console.WriteLine("Not enough money! You need {0:f2} leva.", Math.Abs(left1));
                }
                else if (category == "VIP")
                {
                    var left1 = ost1 - vip * group;
                    if (left1 > 0) Console.WriteLine("Yes! You have {0:f2} leva left.", Math.Abs(left1));
                    else Console.WriteLine("Not enough money! You need {0:f2} leva.", Math.Abs(left1));
                }
            }
            if (group >= 50)
            {
                var ost1 = budget - budget * 0.25;
                if (category == "Normal")
                {
                    var left1 = ost1 - normal * group;
                    if (left1 > 0) Console.WriteLine("Yes! You have {0:f2} leva left.", Math.Abs(left1));
                    else Console.WriteLine("Not enough money! You need {0:f2} leva.", Math.Abs(left1));
                }
                else if (category == "VIP")
                {
                    var left1 = ost1 - vip * group;
                    if (left1 > 0) Console.WriteLine("Yes! You have {0:f2} leva left.", Math.Abs(left1));
                    else Console.WriteLine("Not enough money! You need {0:f2} leva.", Math.Abs(left1));
                }
            }
        }
    }
}
