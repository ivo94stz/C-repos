using System;
using System.Collections.Generic;
using System.Linq;

namespace ShoppingSpree
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string personName;
                decimal personMoney;
                List<Person> people = new List<Person>();

                string[] peopleinput = Console.ReadLine().Split(';', StringSplitOptions.RemoveEmptyEntries);
                for (int i = 0; i < peopleinput.Length; i++)
                {
                    string[] info = peopleinput[i].Split('=');
                    personName = info[0];
                    personMoney = decimal.Parse(info[1]);
                    Person PERSON = new Person(personName, personMoney);
                    people.Add(PERSON);

                }
                string productName;
                decimal productMoney;
                List<Product> products = new List<Product>();


                string[] productsinput = Console.ReadLine().Split(';', StringSplitOptions.RemoveEmptyEntries);
                for (int i = 0; i < productsinput.Length; i++)
                {
                    string[] info = productsinput[i].Split('=');
                    productName = info[0];
                    productMoney = decimal.Parse(info[1]);
                    Product PRODUCT = new Product(productName, productMoney);
                    products.Add(PRODUCT);

                }

                string command = Console.ReadLine();

                while (command != "End")
                {
                    string[] info = command.Split();
                    string PERSONName = info[0];
                    string PRODUCTName = info[1];

                    Person person = people.First(p => p.Name == PERSONName);
                    Product product = products.First(p => p.Name == PRODUCTName);

                    string output = person.TryBuyProduct(product);
                    Console.WriteLine(output);



                }
                foreach (var person in people)
                {
                    Console.WriteLine(person);
                }
            }
            catch(ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }
            notworking;

        }
    }
}
