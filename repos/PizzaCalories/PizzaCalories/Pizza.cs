using System;
using System.Collections.Generic;
using System.Text;


public class Pizza
{
    public string name;
    List<Topping> toppings;
    private Dough dough;

    public Pizza(string name, Dough dough)
    {
        this.Name = name;
        this.Dough = dough;
        this.toppings = new List<Topping>();
    }

    public Dough Dough
    {
        get { return dough; }
        set { dough = value; }
    }


    public string Name
    {
        get { return name; }
        set {
            if (value == string.Empty || value.Length > 15) throw new ArgumentException("Pizza name should be between 1 and 15 symbols.");
            name = value; }
    }

    public int NumberOfToppings()
    {
        return this.toppings.Count;
    }

    public void AddTopping(Topping topping)
    {
        if (this.toppings.Count > 10) throw new ArgumentException("Number of toppings should be in range [0..10].");
        else this.toppings.Add(topping);
    }

    public double Callories()
    {
        double callories = 0;

        callories += this.dough.Calories();
        foreach (Topping topping in this.toppings)
        {
            callories += topping.Calories();


        }
        return callories;
    }


}
