using System;
using System.Collections.Generic;
using System.Text;


public class Rebel:Buyer
{
    public Rebel(string name,int age,string group) : base(name)
    {
    }

    public int Age { get;}
    public string Group { get;}


    public override int AddFood()
    {
        this.Food = 5;
        return this.Food;
    }
}