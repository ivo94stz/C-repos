using System;
using System.Collections.Generic;

namespace Animal
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Animals> animals = new List<Animals>();
            string input;
            while ((input = Console.ReadLine()) != "Beast!")
            {
                string[] info = Console.ReadLine().Split();
                string name = info[0];
                int age = int.Parse(info[1]);
                string gender = info[2];

                try
                {
                    if (input == "Cat")
                    {
                        Cat cat = new Cat(name, age, gender);
                        animals.Add(cat);
                    }
                    else if (input == "Dog")
                    {
                        Dog dog = new Dog(name, age, gender);
                        animals.Add(dog);
                    }
                    else if (input == "Frog")
                    {
                        Frog frog = new Frog(name, age, gender);
                        animals.Add(frog);
                    }
                    else if (input == "Tomcat")
                    {
                        Tomcat tomcat = new Tomcat(name, age, gender);
                        animals.Add(tomcat);
                    }
                    else if (input == "Kittens")
                    {
                        Kittens kitten = new Kittens(name, age, gender);
                        animals.Add(kitten);
                    }
                    else throw new ArgumentException("Invalid input!");
                }
                catch(ArgumentException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                

            }
            foreach (var animal in animals)
            {
                Console.WriteLine(animal.GetType().Name);
                if (animal.GetType().Name == "Kittens")
                {
                    Console.WriteLine($"{animal.Name} {animal.Age} Female");
                }
                else if(animal.GetType().Name == "Tomcat")
                {
                    Console.WriteLine($"{animal.Name} {animal.Age} Male");
                }
                else
                {
                    Console.WriteLine($"{animal.Name} {animal.Age} {animal.Gender}");
                }
                
                Console.WriteLine(animal.ProduceSound());
            }


        }
    }
}
