using System;
using System.Collections.Generic;
using System.Text;

public class Child:Person
{
    public Child(int age, string name):base(age,name)
    {

    }

    public override int Age
    {
        get => base.Age;
        set {
            if (value >= 15) throw new ArgumentException("Child's age must be less than 15!");
            base.Age = value; }
    }
}
