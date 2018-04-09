using System;
using System.Collections.Generic;
using System.Text;


public class Tiger : Feline
{
    public Tiger(string name, double weight, string livingRegion, string breed) 
        : base(name, weight, livingRegion, breed)
    {
    }

    public override string ToString()
    {
        return base.ToString();
    }

    protected override Type[] PreferedFoods()
    {
        return new Type[] { typeof(Meat) };
    }

    
}
