using System;
using System.Collections.Generic;
using System.Text;


public class Kittens : Cat
{
    public Kittens(string name, int age, string gender) 
        : base(name, age, gender)
    {
    }

    public override string ProduceSound()
    {
        return "Meow";
    }
}
