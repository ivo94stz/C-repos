using System;
using System.Collections.Generic;
using System.Text;

public class Worker:Human
{
    decimal weekSalary;
    decimal hoursPerDay;

    public Worker(string firstName, string lastName) : base(firstName, lastName)
    {

    }

    public Worker(string firstName, string lastName,decimal weekSalary, decimal hoursPerDay):this(firstName,lastName)
    {
        this.WeekSalary = weekSalary;
        this.HoursPerDay = hoursPerDay;

    }

    public decimal WeekSalary
    {
        get { return this.weekSalary; }
        set {
            if (value < 11) throw new ArgumentException($"Expected value mismatch! Argument: {nameof(weekSalary)}");
            this.weekSalary = value; }
    }
    public decimal HoursPerDay
    {
        get { return this.hoursPerDay; }
        set {
            if (value < 1 || value > 12) throw new ArgumentException($"Expected value mismatch! Argument: {nameof(hoursPerDay)}");
            this.hoursPerDay = value; }
    }
    private decimal EarnPerHour(decimal weekSalary,decimal hoursPerDay)
    {
        decimal earnPerHour = weekSalary / 5 / hoursPerDay;
        return earnPerHour;
    }

    public override string ToString()
    {
        var builder = new StringBuilder();
        builder.AppendLine($"First Name: {this.FirstName}")
            .AppendLine($"Last Name: {this.LasttName}")
            .AppendLine($"Week Salary: {this.WeekSalary:f2}")
            .AppendLine($"Hours per day: {this.HoursPerDay:f2}")
            .AppendLine($"Salary per hour: {this.EarnPerHour(WeekSalary,HoursPerDay):f2}");
        var result = builder.ToString().TrimEnd();
        return result;
    }

}
