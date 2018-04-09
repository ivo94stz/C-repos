using System;
using System.Collections.Generic;
using System.Linq;

namespace WorkingWithAbstractions
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Car[] cars = new Car[n];

            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine().Split();
                string model = input[0];
                int speed = int.Parse(input[1]);
                int power = int.Parse(input[2]);
                int weight = int.Parse(input[3]);
                string type = input[4];
                double tyre1Pressure = double.Parse(input[5]);
                int tyre1Age = int.Parse(input[6]);
                double tyre2Pressure = double.Parse(input[7]);
                int tyre2Age = int.Parse(input[8]);
                double tyre3Pressure = double.Parse(input[9]);
                int tyre3Age = int.Parse(input[10]);
                double tyre4Pressure = double.Parse(input[11]);
                int tyre4Age = int.Parse(input[12]);


                cars[i] = new Car(model, new Engine(speed, power), new Cargo(weight, type), new List<Tyre> { new Tyre(tyre1Pressure, tyre1Age), new Tyre(tyre2Pressure, tyre2Age), new Tyre(tyre3Pressure, tyre3Age), new Tyre(tyre4Pressure, tyre4Age) });
            }
            string command = Console.ReadLine();
            if (command == "fragile")
            {
                cars.Where(c => c.cargo.type == "fragile").Where(c => c.tires.Any(t => t.pressure < 1)).Select(c => c.model).ToList().ForEach(m => Console.WriteLine(m));
            }
            else if (command == "flamable")
            {
                cars.Where(c => c.cargo.type == "flamable").Where(c => c.engine.power>250).Select(c => c.model).ToList().ForEach(m => Console.WriteLine(m));
            }

        }
    }
}
