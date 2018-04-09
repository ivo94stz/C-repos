using System;
using System.Collections.Generic;
using System.Text;


public class Buyer
{
    public string Name { get; }
    public int Food;

    public Buyer(string name)
    {
        this.Name = name;
        this.Food = 0;
    }


   public virtual int AddFood()
    {

        return this.Food;
    }




}
