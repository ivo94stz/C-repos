using System;
using System.Collections.Generic;
using System.Text;


public class Commando : SpecialisedSoldier
{
    public Dictionary<string,string> Missions { get; }

    public Commando(string id, string firstName, string lastName, double salary,string corps,Dictionary<string,string> missions) 
        : base(id, firstName, lastName, salary,corps)
    {
        this.Missions = missions;
    }
    

    public string CompleteMission()
    {
        return "";
    }

    public override string ToString()
    {
        StringBuilder str = new StringBuilder();
        str.AppendLine($"Name: {this.FirstName} {this.LastName} Id: {this.Id} Salary: {this.Salary:f2}")
            .AppendLine($"Corps: {this.Corps}")
            .AppendLine("Missions:");
        if (Missions.Count > 0)
        {
            foreach (var mission in this.Missions)
            {
                str.AppendLine($"  Code Name: {mission.Key} State: {mission.Value}");
            }
        }
        
        string result = str.ToString().TrimEnd().TrimStart();

        return result;
            
    }
}
