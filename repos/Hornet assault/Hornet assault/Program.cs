using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hornet_assault
{
    class Program
    {
        static void Main(string[] args)
        {
            List<long> beehives = Console.ReadLine().Split(' ').Select(long.Parse).ToList();
            List<long> hornets = Console.ReadLine().Split(' ').Select(long.Parse).ToList();

            List<long> output = new List<long>();
            
            long hornetpower = hornets.Sum();
            while (beehives.Count > 0 && hornets.Count > 0)
            {
                if (hornetpower < beehives[0])
                {
                    output.Add(beehives[0] - hornetpower);
                    hornets.RemoveAt(0);
                    hornetpower = hornets.Sum();
                    beehives.RemoveAt(0);
                }
                else if(hornetpower == beehives[0])
                {
                    hornets.RemoveAt(0);
                    hornetpower = hornets.Sum();
                    beehives.RemoveAt(0);
                }
                
                else
                {
                    beehives.RemoveAt(0);
                }
               
            }
            if (hornets.Count == 0 && beehives.Count > 0)
            {

                Console.Write(string.Join(" ", output) + " ");
                Console.WriteLine(string.Join(" ", beehives));
            }
            else if (output.Count==0) Console.WriteLine(string.Join(" ",hornets));
            else Console.WriteLine(string.Join(" ",output));
        }
    }
}
