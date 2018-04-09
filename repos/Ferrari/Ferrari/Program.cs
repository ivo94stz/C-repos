using System;

namespace Ferrari
{
    class Program
    {
        static void Main(string[] args)
        {

            string driver = Console.ReadLine();
            string model = "488-Spider";

            var car = new Ferrarii(driver, model);
            Console.WriteLine(car);


        }
    }
}
