using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Class1
{
    static void Main()
    {
        var accounts = new Dictionary<int, BankAccount>();
        string command;
        while ((command = Console.ReadLine()) != "End")
        {
            var splitCommand = command.Split();
            var accoundID = int.Parse(splitCommand[1]);
            switch (splitCommand[0])
            {
                case "Create":
                    if (accounts.ContainsKey(accoundID))
                    {
                        Console.WriteLine("Account already exists");
                    }
                    else
                    {
                        var account = new BankAccount();
                        account.ID = accoundID;
                        
                        accounts.Add(accoundID,account);

                    }
                    break;
                case "Deposit":
                    if (validAccount(accoundID, accounts))
                    {
                        accounts[accoundID].deposit(int.Parse(splitCommand[2]));
                    }
                        break;

                case "Withdraw":
                    if (validAccount(accoundID, accounts))
                    {
                        accounts[accoundID].withdraw(int.Parse(splitCommand[2]));
                    }
                    break;
                case "Print":
                    if (validAccount(accoundID, accounts))
                    {
                        Console.WriteLine(accounts[accoundID]);
                    }
                    break;
                default:
                    break;



            }
        }


        
    }
    static bool validAccount(int accountID, Dictionary<int,BankAccount> accounts)
    {
        if (accounts.ContainsKey(accountID))
        {
            return true;
        }
        else
        {
            Console.WriteLine("Account does not exist");
            return false;
        }
    }
}

