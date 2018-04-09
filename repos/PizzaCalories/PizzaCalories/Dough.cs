using System;
using System.Collections.Generic;
using System.Text;


public class Dough
{
    private const double baseCalories = 2;
    private string flourType;
    private string bakingTech;
    private double weight;

    public Dough(string flourType,string bakingTech, double weight)
    {
        this.FlourType = flourType;
        this.BakingTech = bakingTech;
        this.Weight = weight;
    }

    public double  Weight
    {
        get { return weight; }
        set {if (value < 1 || value > 200) throw new ArgumentException("Dough weight should be in the range [1..200].");
            weight = value;
        }
    }
    
    public string FlourType
    {
        get { return flourType; }
        set {if (value.ToLower() != "white" && value.ToLower() != "wholegrain") throw new ArgumentException("Invalid type of dough.");
            flourType = value; }
    }

    public string BakingTech
    {
        get { return bakingTech; }
        set {
            if (value.ToLower() != "crispy" && value.ToLower() != "chewy"&& value.ToLower() != "homemade") throw new ArgumentException("Invalid type of dough.");
            bakingTech = value; }
    }

    public virtual double Calories()
    {
        double modifier = baseCalories;
        if (this.FlourType == "White") modifier *= 1.5;
        else if (this.FlourType == "Wholegrain") modifier *= 1;

        if (this.BakingTech == "Crispy") modifier *= 0.9;
        else if (this.BakingTech == "Chewy") modifier *= 1.1;
        else if (this.BakingTech == "Homemade") modifier *= 1;

        return (modifier * this.Weight) ;
    }

    public override string ToString()
    {
        return $"{Calories():f2}";
    }


}
