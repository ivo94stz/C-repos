using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    public class PersonClass
{
    private int age;
    private string name;
    List<BankAccount> accounts;

    private PersonClass(string name, int age)
    {
        this.name = name;
        this.age = age;
        accounts = new List<BankAccount>();
    }

    public PersonClass(string name,int age, List<BankAccount> accounts):this(name,age)
    {
        this.accounts = accounts;
    }
    public decimal getBalance()
    {
    return accounts.Sum(a => a.Balance);
    }

}

