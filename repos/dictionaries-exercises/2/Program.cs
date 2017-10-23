using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dictionaries_exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(' ');

            var contact = new SortedDictionary<string, string>();

            while (input[0] != "END")
            {
                if (input[0] == "A")
                {
                    string name = input[1];
                    string number = input[2];
                    if (contact.ContainsKey(name))
                    {
                        contact[name] = number;
                    }
                    else
                    {
                        contact.Add(name, number);
                    }
                    
                }
                else if (input[0] == "S")
                {
                    if (contact.ContainsKey(input[1]))
                    {
                        Console.WriteLine("{0} -> {1}", input[1], contact[input[1]]);
                    }
                    else
                    {
                        Console.WriteLine("Contact {0} does not exist.", input[1]);
                    }
                }
                else if (input[0] == "ListAll")
                {
                    foreach (var item in contact)
                    {
                        Console.WriteLine("{0} -> {1}",item.Key,item.Value);
                    }
                }
                input = Console.ReadLine().Split(' ');


            }
        }
    }
}
