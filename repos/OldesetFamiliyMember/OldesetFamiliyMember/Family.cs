using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;


public class Family
{
    List<Person> people;

    public Family()
    {
        this.people = new List<Person>();
    }

    public List<Person> People
    {
        get { return this.people; }
        set { this.people = value; }
    }
    public void AddMember(Person member)
    {
        this.people.Add(member);
    }
    public Person GetOldest()
    {
        return this.people.OrderByDescending(m => m.Age).FirstOrDefault();
            
    }


}
    
