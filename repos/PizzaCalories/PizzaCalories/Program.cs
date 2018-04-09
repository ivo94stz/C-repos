using System;
using System.Collections.Generic;

namespace PizzaCalories
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input0 = Console.ReadLine().Split();
            string pizzaName = input0[1];
           
            string input1 = Console.ReadLine();

            string[] info = input1.Split();
            string flourType = info[1];
            string bakingTech = info[2];
            double weightDough = double.Parse(info[3]);
            try
            {
                Dough dough = new Dough(flourType, bakingTech, weightDough);

            }

            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);

            }

            List<Topping> toppings = new List<Topping>();
            string input2;
            while ((input2 = Console.ReadLine()) != "END")
            {
                string[] info2 = input2.Split();
                string type = info2[1];
                double weightTopping = double.Parse(info2[2]);
                try
                {
                    Topping topping = new Topping(type, weightTopping);
                    toppings.Add(topping);
                }
                catch(ArgumentException ex)
                {
                    Console.WriteLine(ex.Message);
                    continue;
                }

            }
            foreach (Topping topping in toppings)
            {
                Console.WriteLine($"{topping.Calories():f2}");
            }


        }
    }
}

