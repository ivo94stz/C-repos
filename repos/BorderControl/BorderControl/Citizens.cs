using System;
using System.Collections.Generic;
using System.Text;


public class Citizens:Buyer
{
    public Citizens(string name,string id, string birthdate) : base(name)
    {
        
    }

    public string Id { get;  }
    public string Birthdate { get; }


    public override int AddFood()
    {
        this.Food = 10;
        return this.Food;
    }

}
