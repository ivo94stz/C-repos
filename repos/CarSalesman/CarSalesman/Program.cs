using System;
using System.Collections.Generic;
using System.Linq;

namespace CarSalesman
{
    class Program
    {
        static void Main(string[] args)
        {
            var count = int.Parse(Console.ReadLine());
            var engines = new List<Engine>();

            for (int i = 0; i < count; i++)
            {
                var engineInfo = Console.ReadLine().Split().Where(s => s != string.Empty).ToArray();
                var engine = new Engine(engineInfo[0], engineInfo[1]);

                if (engineInfo.Length >= 3)
                {
                    if (engineInfo[2].All(s => char.IsDigit(s)))
                    {
                        engine.Displacement = engineInfo[2];
                    }
                    else
                    {
                        engine.Efficiency = engineInfo[2];
                    }
                }
                if (engineInfo.Length == 4)
                {
                    engine.Efficiency = engineInfo[3];
                }
                engines.Add(engine);

            }
            count = int.Parse(Console.ReadLine());
            var cars = new List<Car>();

            for (int i = 0; i < count; i++)
            {
                var carinfo = Console.ReadLine().Split().Where(c => c != string.Empty).ToArray();
                var car = new Car(carinfo[0], engines.FirstOrDefault(e => e.Model.Equals(carinfo[1])));

                if (carinfo.Length >= 3)
                {
                    if (carinfo[2].All(s => char.IsDigit(s)))
                    {
                        car.Weight = carinfo[2];
                    }
                    else
                    {
                        car.Color = carinfo[2];
                    }
                }
                if (carinfo.Length == 4)
                {
                    car.Color = carinfo[3];
                }
                cars.Add(car);

            }
            foreach (var car in cars)
            {
                Console.WriteLine(car);
            }

        }
    }
}
