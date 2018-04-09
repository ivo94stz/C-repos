using System;
using System.Collections.Generic;
using System.Text;


public class Ferrarii:IFerrari
{
    private string model;

    public string Model
    {
        get { return model; }
        set { model = value; }
    }
    private string driver;

    public string Driver
    {
        get { return driver; }
        set { driver = value; }
    }

    public Ferrarii(string driver, string model)
    {
        this.Driver = driver;
        this.Model = model;
    }
    public string Brakes()
    {
        return "Brakes!";
    }

    public string Gas()
    {
        return "Zadu6avam sA!";
    }

    public override string ToString()
    {
        return $"{this.Model}/{this.Brakes()}/{this.Gas()}/{this.Driver}";
    }

}
