using System;
using System.Collections.Generic;
using System.Text;


public class LeutenantGeneral : Private
{
    public List<Private> PrivateSoldiers { get; }
    public List<string> PrivateIds { get; set; }

    public LeutenantGeneral(string id, string firstName, string lastName, double salary,List<Private> privateSoldiers,List<string> privateIds)
       : base(id, firstName, lastName, salary)
    {
        this.PrivateSoldiers = privateSoldiers;
        this.PrivateIds = privateIds;
    }

    public override string ToString()
    {
        StringBuilder str = new StringBuilder();
        str.AppendLine($"Name: {this.FirstName} {this.LastName} Id: {this.Id} Salary: {this.Salary:f2}")
            .AppendLine("Privates:");
        PrivateSoldiers.Reverse();


        foreach (var privateId in PrivateIds)
        {
            foreach (var privates in PrivateSoldiers)
            {
                if (privates.Id == privateId)
                {
                    str.AppendLine($"  Name: {privates.FirstName} {privates.LastName} Id: {privates.Id} Salary: {privates.Salary:f2}");
                }
            }
        }
        

        string result = str.ToString().TrimEnd().TrimStart();
        
        return result;
    }
}
