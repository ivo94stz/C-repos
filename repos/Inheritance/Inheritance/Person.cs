using System;
using System.Collections.Generic;
using System.Text;

public class Person
{
    int age;
    string name;

    public virtual int Age
    {
        get { return this.age; }
        set {
            if (value < 0) throw new ArgumentException("Age must be positive!");
            this.age = value; }
    }

    public virtual string Name
    {
        get { return this.name; }
        set {
            if (value.Length < 3) throw new ArgumentException("Name's length should not be less than 3 symbols!");
            this.name = value; }
    }

    public Person(int age,string name)
    {
        this.Age = age;
        this.Name = name;
    }

    public override string ToString()
    {
        return $"Name: {this.Name}, Age: {this.Age}";
    }
}

