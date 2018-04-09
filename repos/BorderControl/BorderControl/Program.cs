using System;
using System.Collections.Generic;
using System.Linq;

namespace BorderControl
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Buyer> buyers = new List<Buyer>();
            List<string> names = new List<string>();

            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split();
                if (input.Length == 3)
                {
                    string name = input[0];
                    Rebel rebel = new Rebel(name, 0, "");
                    
                    buyers.Add(rebel);
                }
                else if (input.Length == 4)
                {
                    string name = input[0];
                    Citizens citizen = new Citizens(name, "", "");
                    
                    buyers.Add(citizen);
                }
                
            }

            string info;
            while ((info = Console.ReadLine()) != "End")
            {
                names.Add(info);
            }

            int result = 0;
            foreach (var name in names)
            {
                foreach (var buyer in buyers)
                {
                   
                    if (buyer.Name == name)
                    {

                        int plus = buyer.AddFood();
                        result += plus;
                        
                    }
                }
            }
            Console.WriteLine(result);
        }
    }
}
