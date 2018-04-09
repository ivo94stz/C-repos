using System;
using System.Collections.Generic;
using System.Text;


public class Private : Soldier
{
    public double Salary { get; }

    public Private(string id, string firstName, string lastName,double salary) 
        : base(id, firstName, lastName)
    {
        this.Salary = salary;
    }

    public override string ToString()
    {
        StringBuilder str = new StringBuilder();
        str.AppendLine($"Name: {this.FirstName} {this.LastName} Id: {this.Id} Salary: {this.Salary:f2}");
        string result = str.ToString().TrimEnd().TrimStart();
        return result; 
    }
}
