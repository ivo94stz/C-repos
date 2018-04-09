using System;
using System.Collections.Generic;
using System.Text;


public class Owl : Bird
{
    public Owl(string name, double weight, double wingSize)
        : base(name, weight, wingSize)
    {
    }

    protected override Type[] PreferedFoods()
    {
        return new Type[] { typeof(Meat) };
    }

    protected override double WeightIncrease()
    {
        return 0.25;
    }
}
