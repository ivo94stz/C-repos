using System.Collections.Generic;
using System.Linq;

public class Department
{
    private List<Company> company;
    string name;
    public string Name
    {
        get { return this.name; }
        set { this.name = value; }
    }

    public Department(string name)
    {
        this.Company = new List<global::Company>();
        this.Name = name;
    }

    public List<Company> Company
    {
        get { return company; }
        set { company = value; }
    }

    public decimal AverageSalary => this.Company.Select(c => c.Salary).Average();

    public void AddCompany(Company company)
    {
        this.Company.Add(company);
    }
    
        
}