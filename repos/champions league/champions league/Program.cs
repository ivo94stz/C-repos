using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace champions_league
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            var teamWins = new Dictionary<string, int>();
            var opponents = new Dictionary<string, List<string>>();

            while (input != "stop")
            {
                var info = input.Split(new[]{" | ",":"},StringSplitOptions.RemoveEmptyEntries).ToArray();
                var firstteam = info[0];
                var secondteam = info[1];
                int goalsfirst = int.Parse(info[2] + info[5]);
                int goalsSeccond = int.Parse(info[3] + info[4]);

                if (goalsfirst > goalsSeccond)
                {
                    if (!teamWins.ContainsKey(firstteam))
                    {
                        teamWins[firstteam] = 1;
                    }
                    else
                    {
                        teamWins[firstteam]++;
                    }
                    if (!teamWins.ContainsKey(secondteam))
                    {
                        teamWins[secondteam] = 0;
                    }
                }
                else if (goalsfirst < goalsSeccond)
                {
                    if (!teamWins.ContainsKey(secondteam))
                    {
                        teamWins[secondteam] = 1;
                    }
                    else
                    {
                        teamWins[secondteam]++;
                    }
                    if (!teamWins.ContainsKey(firstteam))
                    {
                        teamWins[firstteam] = 0;
                    }
                }
                else
                {
                    if (int.Parse(info[5]) > int.Parse(info[3]))
                    {
                        if (!teamWins.ContainsKey(firstteam))
                        {
                            teamWins[firstteam] = 1;
                        }
                        else
                        {
                            teamWins[firstteam]++;
                        }
                        if (!teamWins.ContainsKey(secondteam))
                        {
                            teamWins[secondteam] = 0;
                        }
                    }
                    else
                    {
                        if (!teamWins.ContainsKey(secondteam))
                        {
                            teamWins[secondteam] = 1;
                        }
                        else
                        {
                            teamWins[secondteam]++;
                        }
                        if (!teamWins.ContainsKey(firstteam))
                        {
                            teamWins[firstteam] = 0;
                        }
                    }
                }

                if (!opponents.ContainsKey(firstteam))
                {
                    opponents[firstteam] = new List<string>();
                    opponents[firstteam].Add(secondteam);
                }
                else
                {
                    opponents[firstteam].Add(secondteam);
                }
                if (!opponents.ContainsKey(secondteam))
                {
                    opponents[secondteam] = new List<string>();
                    opponents[secondteam].Add(firstteam);
                }
                else
                {
                    opponents[secondteam].Add(firstteam);
                }
                opponents[firstteam].Sort();
                opponents[secondteam].Sort();


                input = Console.ReadLine();
            }

            foreach (var item in teamWins.OrderByDescending(x=>x.Value).ThenBy(x=>x.Key))
            {
                Console.WriteLine(item.Key);
                Console.WriteLine("- Wins: {0}",item.Value);
                if (opponents.ContainsKey(item.Key))
                {
                    Console.WriteLine("- Opponents: {0}", string.Join(", ", opponents[item.Key]));
                    
                }
            }



            //foreach (var item in opponents)
            //{
            //    Console.WriteLine(item.Key);
            //    Console.WriteLine("- Opponents: {0}",string.Join(", ",item.Value));
            //}

        }
    }
}
