using System;
using System.Collections.Generic;

namespace WildFarm
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Animal> animals = new List<Animal>();

            string input;
            while((input = Console.ReadLine()) != "End")
            {
                string[] animalTokens = input.Split();
                string animalType = animalTokens[0];
                string name = animalTokens[1];
                double weight = double.Parse(animalTokens[2]);
                string thirdToken = animalTokens[3];
                
                if (animalType == "Cat")
                {
                    string catBreed = animalTokens[4];
                    animal = new Cat(name, weight, thirdToken, catBreed);
                    Console.WriteLine(animal);
                }
                else if (animalType == "Tiger")
                {
                    string tigerBreed = animalTokens[4];
                    animal = new Tiger(name, weight, thirdToken, tigerBreed);
                    Console.WriteLine(animal);
                }
                else if (animalType == "Dog")
                {
                    animal = new Dog(name, weight, thirdToken);
                }
                else if (animalType == "Mouse")
                {
                    animal = new Mouse(name, weight, thirdToken);
                }
                else if (animalType == "Owl")
                {
                    double wingSize = double.Parse(thirdToken);
                    animal = new Owl(name, weight, wingSize);
                }
                else if (animalType == "Hen")
                {
                    double wingSize = double.Parse(thirdToken);
                    animal = new Hen(name, weight, wingSize);
                }
                else throw new ArgumentException("Invalid animal type!");

                string[] foodTokens = Console.ReadLine().Split();
            }
        }
    }
}
