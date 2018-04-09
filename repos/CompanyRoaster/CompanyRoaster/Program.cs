using System;
using System.Collections.Generic;
using System.Linq;

namespace CompanyRoaster
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Department> departments = new List<Department>();
            
            int people = int.Parse(Console.ReadLine());

          

            for (int i = 0; i < people; i++)
            {
                string[] input = Console.ReadLine().Split();
                string depname = input[3];


                if (!departments.Any(d => d.Name == depname))
                {
                    Department dep = new Department(depname);
                    departments.Add(dep);
                }
                var department = departments.FirstOrDefault(d => d.Name == depname);
                Company company = ParseCompany(input);
                department.AddCompany(company);
                
            }
            var highestavg = departments.OrderByDescending(d => d.AverageSalary).First();
            Console.WriteLine("Highest Average Salary: {0}",highestavg.Name);
            foreach (var item in highestavg.Company.OrderByDescending(d=>d.Salary))
            {
                Console.WriteLine("{0} {1:f2} {2} {3}",item.Name,item.Salary,item.Email,item.Age);
            }

        }
        static Company ParseCompany(string[]input)
        {
            

            string name = input[0];
            decimal salary = decimal.Parse(input[1]);
            string position = input[2];
            
            string email = "n/a";
            int age = -1 ;

            if (input.Length == 6)
            {
                email = input[4];
                age = int.Parse(input[5]);

            }
            else if (input.Length == 5)
            {
                bool isage = int.TryParse(input[4], out age);
                if (!isage)
                {
                    email = input[4];
                    age = -1;
                }
            }
            Company company = new Company(name, position, salary, age, email);
            return company;
        }
    }
}
