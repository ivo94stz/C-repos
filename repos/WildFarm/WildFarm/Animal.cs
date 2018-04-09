using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;


public abstract class Animal
{
    public Animal(string name, double weight)
    {
        this.Name = name;
        this.Weight = weight;
        this.FootEaten = 0;
    }

    public string Name { get; set; }
    public double Weight { get; set; }
    public int FootEaten { get; set; }

    protected virtual double WeightIncrease()
    {
        return 1;
    }

    protected virtual Type[] PreferedFoods()
    {
        return new Type[] { typeof(Food) };
    }

    public void TryEatFood(Food food)
    {
        Type typeOfFood = food.GetType();
        if (!this.PreferedFoods().Contains(food.GetType()))
        {
            throw new InvalidOperationException($"{this.GetType().Name} does not eat {typeOfFood.Name}!");
        }
        this.FootEaten += food.Quantity;
        this.Weight += food.Quantity * this.WeightIncrease();

    }

    public override string ToString()
    {
        return $"{this.GetType().Name} [{this.Name}, " +"{0}"+ $", {this.Weight}, " +"{1}" + $"{this.FootEaten}]";
    }

}