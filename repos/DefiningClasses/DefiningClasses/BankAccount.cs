using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    public class BankAccount
    {
        int id;
        public int ID
        {
            get { return id; }
            set { id = value; }
        }

        decimal balance;

        public decimal Balance
        {
            get { return balance; }
            set { balance = value; }
        }

        
        public void deposit(decimal amount)
        {
            Balance += amount;
        }
        public void withdraw(decimal amount)
        {
        if (balance < amount)
        {
            Console.WriteLine("Insufficient balance");
        }
        else
        {
            Balance -= amount;
        }
            
        }
        public override string ToString()
        {
            return $"Account ID{ID}, balance {Balance:f2}";
        }


    }

