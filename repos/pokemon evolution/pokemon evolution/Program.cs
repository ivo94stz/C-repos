using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pokemon_evolution
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] splitters = { ' ', '-', '>' };
            var input = Console.ReadLine().Split(splitters,StringSplitOptions.RemoveEmptyEntries).ToArray();

            var output = new Dictionary<string, Dictionary<string, int>>();



            while (input[0] != "wubbalubbadubdub")
            {
                string name = input[0];
                string evolution = input[1];
                int index = int.Parse(input[2]);

                if (!output.ContainsKey(name))
                {
                    output[name] = new Dictionary<string, int>();
                    output[name].Add(evolution, index);
                }
                else
                {
                    output[name].Add(evolution, index);
                }





                input = Console.ReadLine().Split(splitters, StringSplitOptions.RemoveEmptyEntries).ToArray();
            }



            foreach (var hero in output)
            {
                Console.WriteLine("# {0}", hero.Key);
                foreach (var evol in hero.Value.OrderBy(x=>-x.Value))
                {
                    Console.WriteLine("{0} <-> {1}",evol.Key,evol.Value);
                }
            }
        }
    }
}
