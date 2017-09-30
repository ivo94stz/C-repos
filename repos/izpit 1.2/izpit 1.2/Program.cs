using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace izpit_1._2
{
    class Program
    {
        static void Main(string[] args)
        {
            var x = double.Parse(Console.ReadLine());
            var y = double.Parse(Console.ReadLine());
            var z = double.Parse(Console.ReadLine());
            var broi = double.Parse(Console.ReadLine());

            var need = x * 0.4;
            var wine = y * need;
            var proizv = wine / 2.5;
            var nedostig = Math.Floor(z - proizv);
            var izlishuk = Math.Floor(proizv - z);
            var rabotnik = Math.Round(izlishuk / broi);

            if (proizv < z) Console.WriteLine("It will be a tough winter! More {0} liters wine needed.", nedostig);
            else
            {
                Console.WriteLine("Good harvest this year! Total wine: {0} liters.", proizv);
                Console.WriteLine("{0} liters left -> {1} liters per person.", izlishuk, rabotnik);

            }
        }
    }
}
