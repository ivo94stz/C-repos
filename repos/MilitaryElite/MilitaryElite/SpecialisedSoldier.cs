using System;
using System.Collections.Generic;
using System.Text;


public class SpecialisedSoldier : Private
{
    public string Corps { get; set; }

    public SpecialisedSoldier(string id, string firstName, string lastName, double salary, string corps)
        : base(id, firstName, lastName, salary)
    {
        this.Corps = corps;
    }

    


    



}
