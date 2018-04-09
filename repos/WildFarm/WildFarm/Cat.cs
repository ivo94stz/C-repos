using System;
using System.Collections.Generic;
using System.Text;


public class Cat : Feline
{
    public Cat(string name, double weight, string livingRegion, string breed) 
        : base(name, weight, livingRegion, breed)
    {
    }

    protected override Type[] PreferedFoods()
    {
        return new Type[] { typeof(Meat), typeof(Vegetable) };
    }

    protected override double WeightIncrease()
    {
        return 0.3;
    }
}
