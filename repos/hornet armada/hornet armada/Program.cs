using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hornet_armada
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var legions = new Dictionary<string, long>();
            var soldier = new Dictionary<string,Dictionary<string, long>>();

            for (int i = 0; i < n; i++)
            {
                char[] splitters = { ' ', '=', '-', '>', ':' };
                var input = Console.ReadLine().Split(splitters,StringSplitOptions.RemoveEmptyEntries).ToArray();
                long activity =long.Parse( input[0]);
                string name = input[1];
                string soldiertype = input[2];
                long soldiercount = long.Parse(input[3]);

                if (!soldier.ContainsKey(name))
                {
                    legions[name] = activity;
                    soldier[name] = new Dictionary<string, long>();
                    
                }
                if (!soldier[name].ContainsKey(soldiertype))
                {
                    soldier[name][soldiertype] = 0;
                }
                else
                {
                    soldier[name][soldiertype] += soldiercount;
                }

                if (activity > legions[name])
                {
                    legions[name] = activity;
                }
            }
            var input1 = Console.ReadLine().Split('\\').ToArray();
            if (input1.Length == 1)
            {
                var soldiertype = input1[0];


                foreach (var legion in legions.OrderByDescending(x=>x.Value))
                {
                    if (soldier[legion.Key].ContainsKey(soldiertype))
                    {
                        Console.WriteLine("{0} : {1}",legion.Value,legion.Key);
                    }
                }


            }
            else
            {
                var soldiertype =( input1[1]);
                var activity = long.Parse(input1[0]);

                foreach (var sol in soldier.OrderByDescending(x=>x.Value[soldiertype]))
                {
                    if (legions[sol.Key] < activity && soldier[sol.Key].ContainsKey(soldiertype))
                    {
                        Console.WriteLine("{0} -> {1}", sol.Key,soldier[sol.Key][soldiertype]);
                    }


                }



            }

        }
    }
}
