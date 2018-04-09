using System;
using System.Collections.Generic;
using System.Text;


public class Student:Human
{
    string faculty;

    public Student(string firstName, string lastName):base(firstName,lastName)
    {
            
    }

    public Student(string firstName,string lastName, string faculty):this(firstName,lastName)
    {
        this.Faculty = faculty;
    }

    public string Faculty
    {
        get { return this.faculty; }
        set {
            if (value.Length < 5 || value.Length > 10) throw new ArgumentException("Invalid faculty number!");
            for (int i = 0; i < value.Length; i++)
            {
                if (!char.IsLetterOrDigit(value[i]))
                {
                    throw new ArgumentException("Invalid faculty number!");
                }
            }
            this.faculty = value;
        }
    }
    public override string ToString()
    {
        var builder = new StringBuilder();
        builder.AppendLine($"First Name: {this.FirstName}")
            .AppendLine($"Last Name: {this.LasttName}")
            .AppendLine($"Faculty number: {this.Faculty}");
        var result = builder.ToString().TrimEnd();
        return result;
    }

}
