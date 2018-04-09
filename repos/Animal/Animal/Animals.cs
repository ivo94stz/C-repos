using System;
using System.Collections.Generic;
using System.Text;


public abstract class Animals
{
    private string name;
    private int age;
    private string gender;

    public Animals(string name,int age,string gender)
    {
        this.Name = name;
        this.Age = age;
        this.Gender = gender;
    }

    public string Name
    {
        get { return name; }
        set {if (value == string.Empty) throw new ArgumentException("Invalid input!");
            name = value; }
    }
    
    public int Age
    {
        get { return age; }
        set {if (value < 0) throw new ArgumentException("Invalid input!");
            age = value; }
    }
    
    public string Gender
    {
        get { return gender; }
        set {if (value == string.Empty) throw new ArgumentException("Invalid input!");
            gender = value; }
    }

    public virtual string ProduceSound()
    {
        return "";
    }

   
}