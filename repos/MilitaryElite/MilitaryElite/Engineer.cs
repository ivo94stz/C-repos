using System;
using System.Collections.Generic;
using System.Text;


public class Engineer : SpecialisedSoldier
{
    public Engineer(string id, string firstName, string lastName, double salary,string corps,Dictionary<string,int> repairs) 
        : base(id, firstName, lastName, salary,corps)
    {
        this.Repairs = repairs;
    }

    public Dictionary<string,int> Repairs { get; set; }


    public override string ToString()
    {
        StringBuilder str = new StringBuilder();
        str.AppendLine($"Name: {this.FirstName} {this.LastName} Id: {this.Id} Salary: {this.Salary:f2}")
            .AppendLine($"Corps: {this.Corps}")
            .AppendLine("Repairs:");

        foreach (var repair in this.Repairs)
        {
            str.AppendLine($"  Part Name: {repair.Key} Hours Worked: {repair.Value}");
        }
        string result = str.ToString().TrimEnd().TrimStart();

        return result;
    }

}
