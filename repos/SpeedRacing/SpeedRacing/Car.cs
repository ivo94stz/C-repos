using System;
using System.Collections.Generic;
using System.Text;


public class Car
{
    string model;
    decimal fuelAmount;
    decimal fuelConsumption;
    decimal distance;

    public string Model { get; set; }
    public decimal FuelAmount { get; set; }
    public decimal FuelConsumption { get; set; }
    public decimal Distance { get; set; }

    public Car(string model, decimal fuelAmount,decimal fuelConsumption)
    {
        this.Model = model;
        this.FuelAmount = fuelAmount;
        this.FuelConsumption = fuelConsumption;
        this.distance = 0;
    }
    public static bool CanDrive(Car car, decimal distance)
    {
        var km = car.fuelAmount / car.fuelConsumption;
        if (km >= distance)
        {
            var litres = distance * car.fuelConsumption;
            car.fuelAmount -= litres;
            car.distance += distance;
            return true;
        }
        return false;
    }


}
   
