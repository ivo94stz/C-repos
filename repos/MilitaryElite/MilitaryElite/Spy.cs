using System;
using System.Collections.Generic;
using System.Text;


public class Spy : Soldier
{
    public int CodeNumber { get; set; }

    public Spy(string id, string firstName, string lastName,int codeNumber)
        : base(id, firstName, lastName)
    {
        this.CodeNumber = codeNumber;
    }

    public override string ToString()
    {
        StringBuilder str = new StringBuilder();
        str.AppendLine($"Name: {this.FirstName} {this.LastName} Id: {this.Id}")
            .AppendLine($"Code Number: {this.CodeNumber}");
        string result = str.ToString().TrimEnd().TrimStart();
        return result; 
    }
}
