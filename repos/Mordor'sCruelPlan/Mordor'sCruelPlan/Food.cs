using System;
using System.Collections.Generic;
using System.Text;


public abstract class Food
{
    private string Name { get;  }

    private Food(string name)
    {
        this.Name = name;
    }

}
