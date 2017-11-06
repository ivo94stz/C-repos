using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cubic_messeges
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = "";


            while (true)
            {
                input = Console.ReadLine();
                if (input == "Over!") break;
                int m = int.Parse(Console.ReadLine());
                string message = input;
                List<int> before = new List<int>();

                for (int i = 0; i < message.Length; i++)
                {
                    if (char.IsDigit(message[i]))
                    {
                        int digitbefore =int.Parse( message[i].ToString());
                        before.Add(digitbefore);
                        
                        //i--;
                    }
                    
                }
                message.Remove(0,before.Count);
                Console.WriteLine(message);


            }
           


        }
    }
}
