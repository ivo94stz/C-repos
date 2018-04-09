using System;
using System.Collections.Generic;
using System.Text;


public class Topping
{
    private const double baseCalories = 2;
    private string type;
    private double weight;

    public Topping(string type, double weight)
    {
        this.Type = type;
        this.Weight = weight;
    }

    public double Weight
    {
        get { return weight; }
        set {
            if (value < 1 && value > 50) throw new ArgumentException($"{nameof(this.Type)} weight should be in the range [1..50].");
            weight = value; }
    }
    
    public string Type
    {
        get { return type; }
        set {
            if (value.ToLower() != "meat" && value.ToLower() != "veggies" && value.ToLower() != "cheese" && value.ToLower() != "sauce") throw new ArgumentException($"Cannot place {nameof(type)} on top of your pizza.");
            type = value; }
    }

    public double Calories()
    {
        double modifier = baseCalories;
        if (this.Type == "Meat") modifier *= 1.2;
        else if (this.Type == "Veggies") modifier *= 0.8;
        else if (this.Type == "Cheese") modifier *= 1.1;
        else if (this.Type == "Sauce") modifier *= 0.9;


        return this.Weight * modifier;
    }



}
