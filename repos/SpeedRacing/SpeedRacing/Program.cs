using System;
using System.Collections.Generic;
using System.Linq;

namespace SpeedRacing
{
    class Program
    {
        static void Main(string[] args)
        {
            var cars = new List<Car>();

            var n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                var info = Console.ReadLine().Split();
                var model = info[0];
                var fuelAmount = decimal.Parse(info[1]);
                var fuelConsumption = decimal.Parse(info[2]);

                cars.Add(new Car(model, fuelAmount, fuelConsumption));
            }
            var command = Console.ReadLine();
            while (command != "End")
            {
                command.Split();
                var model = command[1];
                var distance = command[2];

                var currentCar = cars.FirstOrDefault(c => c.Model == model.ToString());

                if (!Car.CanDrive(currentCar, distance))
                {
                    Console.WriteLine("Insufficient fuel for the drive") ;
                }
                command = Console.ReadLine();

            }
            foreach (var car in cars)
            {
                Console.WriteLine("{0} {1:f2} {2}",car.Model,car.FuelAmount,(int)car.Distance);

            }


        }
    }
}
