using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19._03._17_2
{
    class Program
    {
        static void Main(string[] args)
        {
            var plan = double.Parse(Console.ReadLine());
            var rab = double.Parse(Console.ReadLine());
            var days = double.Parse(Console.ReadLine());

            var hours = rab * days * 8;
            var cups =Math.Floor( hours / 5);
            var razlika = Math.Abs((plan - cups)*4.2);

            if (plan > cups) Console.WriteLine("Losses: {0:f2}", razlika);
            else if (plan <= cups) Console.WriteLine("{0:f2} extra money", razlika);



        }
    }
}
