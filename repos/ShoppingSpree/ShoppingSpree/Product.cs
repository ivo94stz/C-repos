using System;
using System.Collections.Generic;
using System.Text;


public class Product
{
    public string name;
    public decimal cost;

    public Product(string name,decimal cost)
    {
        this.Name = name;
        this.Cost = cost;
    }

    public string Name
    {
        get { return this.name; }
        private set
        {
            if (value == null || value == "" || value == " ")
            {
                throw new ArgumentException("Name cannot be empty");
            }
            this.name = value;
        }
    }
    public decimal Cost
    {
        get { return this.cost; }
        private set
        {
            if (value<0)
            {
                throw new ArgumentException("Money cannot be negative");
            }
            this.cost = value;
        }
    }
    public override string ToString()
    {
        return this.Name;
    }


}

