using System;
using System.Collections.Generic;
using System.Text;


public class FoodFactory:Food
{
    public int Points { get;  }

    public FoodFactory(string name, int points)
        :base(name)
    {
        this.Points = 0;
    }

    public string CalculatePoints(List<> argumets)
    {

    }

}
