using System;
using System.Collections.Generic;
using System.Text;


public abstract class Food
{
    public List<string> Name { get; set; }

    public Food(List<string> name)
    {
        this.Name = new List<string>();
    }
}
