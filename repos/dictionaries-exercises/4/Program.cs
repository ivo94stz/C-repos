using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4
{
    class Program
    {
        static void Main(string[] args)
        {
            var name = Console.ReadLine();
            string email = "";
            var collect = new Dictionary<string, string>();

            while(true)
            {
                if (name == "stop") break;
                email = Console.ReadLine();
                if (email.EndsWith("us") || email.EndsWith("uk"))
                {
                    
                    
                }
                else
                {
                    collect.Add(name, email);
                }



                name = Console.ReadLine();
                if (name == "stop") break;
                
            }
            foreach (var item in collect)
            {
                Console.WriteLine("{0} -> {1}",item.Key,item.Value);
            }


        }
    }
}
