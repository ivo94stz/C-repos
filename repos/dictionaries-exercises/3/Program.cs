using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3
{
    class Program
    {
        static void Main(string[] args)
        {

            var minertask = new Dictionary<string, int>();

            

            while (true)
            {
                var resource = Console.ReadLine();

                if(resource == "stop")
                {
                    break;
                }

                int quantity = int.Parse(Console.ReadLine());


                if (!minertask.ContainsKey(resource))
                {
                    minertask[resource] = quantity;
                }
                else
                {
                    minertask[resource] += quantity;
                }

            
            }


            foreach (var item in minertask)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }


            //while (true)
            //{
            //    string resource = Console.ReadLine();

            //    if (resource == "stop")
            //    {
            //        break;
            //    }


            //    int quantity = int.Parse(Console.ReadLine());
            //    if (minertask.ContainsKey(resource))
            //    {
            //        minertask[resource] += quantity;


            //    }

            //    else
            //    {
            //        minertask[resource] = quantity;
            //    }
            //    Console.WriteLine("{0} -> {1}", resource, minertask[resource]);
            //    if (resource == "stop") break;
            //    resource = Console.ReadLine();
            //    quantity = int.Parse(Console.ReadLine());


            //}

        }
    }
}
