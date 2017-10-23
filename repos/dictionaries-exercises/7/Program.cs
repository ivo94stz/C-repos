using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7
{
    class Program
    {
        static void Main(string[] args)
        {
            string input1 = "";

            
            var population = new Dictionary<string, Dictionary<string, long>>();




            while ((input1 = Console.ReadLine()) != "report")
            {
               string[] input = input1.Split(new char[] { '|' }, StringSplitOptions.RemoveEmptyEntries);

                string city = input[0];
                string country = input[1];
                int cityPopulation = int.Parse(input[2]);
                population[input[1]] = new Dictionary<string, long>();

                if (!population.ContainsKey(country))
                {
                    population[country] = new Dictionary<string, long>();

                }
                population[country][city] = cityPopulation;
                


            
                input = Console.ReadLine().Split('|').ToArray();
            }
        
            
            foreach (var item in population.OrderBy(x=>-x.Value.Values.Sum()))
            {
                Console.WriteLine("{0} (total population: {1})",item.Key,item.Value.Values.Sum());
                foreach (var city in item.Value.OrderBy(x=> -x.Value))
                {
                    Console.WriteLine("=>{0}: {1}",city.Key,city.Value);
                }
                
            }

        }
    }
}
