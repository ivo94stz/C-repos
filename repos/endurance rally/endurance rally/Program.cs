using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace endurance_rally
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] drivers = Console.ReadLine().Split(' ').ToArray();
            double[] zones = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();
            int[] checkpoint = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            foreach (var driver in drivers)
            {
                double fuel = driver[0];
                int reach = 0;

                for (int i = 0; i < zones.Length; i++)
                {
                    reach = i;
                    if (checkpoint.Contains(i))
                    {
                        fuel += zones[i];
                        
                    }
                    else
                    {
                        fuel -= zones[i];
                        
                    }
                    if (fuel < 0) break;

                }
                if (fuel > 0)
                {
                    Console.WriteLine("{0} - fuel left {1:f2}", driver, fuel);
                }
                else
                {
                    Console.WriteLine("{0} - reached {1}", driver, reach);
                }



            }



        }
    }
}
