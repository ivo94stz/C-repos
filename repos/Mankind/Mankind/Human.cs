using System;
using System.Collections.Generic;
using System.Text;

public class Human
{
    string firstName;
    string lastName;

    public Human(string firstName, string lastName)
    {
        this.FirstName = firstName;
        this.LasttName = lastName;
    }

    public string FirstName
    {
        get { return this.firstName; }
        set {
            if (!char.IsUpper(value[0])) throw new ArgumentException($"Expected upper case letter! Argument: {nameof(firstName)}");
            if (value.Length < 4) throw new ArgumentException($"Expected length at least 4 symbols! Argument: {nameof(firstName)}");
            else this.firstName = value;
        }
    }
    public string LasttName
    {
        get { return this.lastName; }
        set {
            if (!char.IsUpper(value[0])) throw new ArgumentException($"Expected upper case letter! Argument: {nameof(lastName)}");
            if (value.Length < 3) throw new ArgumentException($"Expected length at least 4 symbols! Argument: {nameof(lastName)}");
            else this.lastName = value;
        }
    }
}
