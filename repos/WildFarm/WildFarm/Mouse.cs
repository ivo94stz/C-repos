using System;
using System.Collections.Generic;
using System.Text;


public class Mouse : Mammal
{
    public Mouse(string name, double weight, string livingRegion) 
        : base(name, weight, livingRegion)
    {
    }

    public override string ToString()
    {
        string fromBase = base.ToString();
        string result = string.Format(fromBase, string.Empty);

        return result;
    }

    protected override Type[] PreferedFoods()
    {
        return new Type[] { typeof(Vegetable), typeof(Fruit) };
    }

    protected override double WeightIncrease()
    {
        return 0.1;
    }
}
