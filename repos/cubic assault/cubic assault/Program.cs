using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace cubic_assault
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            string regionName = "";
            string meteorType = "";
            ulong count = 0;
            ulong greencount = 0;
            ulong redcount = 0;
            ulong blackcount = 0;
            var meteorStats = new Dictionary<string, Dictionary<string, ulong>>();


            while(input!="Count em all")
            {
                var info = input.Split(new[] { " -> " }, StringSplitOptions.RemoveEmptyEntries).ToArray();
                regionName = info[0];
                meteorType = info[1];
                count = ulong.Parse(info[2]);
                ulong milion = 1000000;

                //if (meteorType == "Green") greencount += count;
                //else if (meteorType == "Red") redcount += count;
                //else if (meteorType == "Black") blackcount += count;

                if (!meteorStats.ContainsKey(regionName))
                {
                    meteorStats[regionName] = new Dictionary<string, ulong>();
                    if (!meteorStats[regionName].ContainsKey(meteorType))
                    {
                        meteorStats[regionName][meteorType] = count;
                        if (meteorStats[regionName][meteorType] >= milion && meteorType == "Green")
                        {
                            var moved = meteorStats[regionName][meteorType] / milion;
                            redcount += moved;
                            meteorStats[regionName][meteorType] = meteorStats[regionName][meteorType] % (moved * milion);
                            meteorStats[regionName][meteorType] += redcount;
                        }
                        else if (meteorStats[regionName][meteorType] >= milion && meteorType == "Red")
                        {
                            var moved = meteorStats[regionName][meteorType] / milion;
                            blackcount += moved;
                            meteorStats[regionName][meteorType] = meteorStats[regionName][meteorType] % (moved * milion);
                            meteorStats[regionName][meteorType] += blackcount;
                        }
                        
                    }
                    else
                    {
                        meteorStats[regionName][meteorType] += count;
                        if (meteorStats[regionName][meteorType] >= milion && meteorType == "Green")
                        {
                            var moved = meteorStats[regionName][meteorType] / milion;
                            redcount += moved;
                            meteorStats[regionName][meteorType] = meteorStats[regionName][meteorType] % (moved * milion);
                            meteorStats[regionName][meteorType] += redcount;
                        }
                        else if (meteorStats[regionName][meteorType] >= milion && meteorType == "Red")
                        {
                            var moved = meteorStats[regionName][meteorType] / milion;
                            blackcount += moved;
                            meteorStats[regionName][meteorType] = meteorStats[regionName][meteorType] % (moved * milion);
                            meteorStats[regionName][meteorType] += blackcount;
                        }
                    }
                }
                else
                {
                    if (!meteorStats[regionName].ContainsKey(meteorType))
                    {
                        meteorStats[regionName][meteorType] = count;
                        if (meteorStats[regionName][meteorType] >= milion && meteorType == "Green")
                        {
                            var moved = meteorStats[regionName][meteorType] / milion;
                            redcount += moved;
                            meteorStats[regionName][meteorType] = meteorStats[regionName][meteorType] % (moved * milion);
                            meteorStats[regionName][meteorType] += redcount;
                        }
                        else if (meteorStats[regionName][meteorType] >= milion && meteorType == "Red")
                        {
                            var moved = meteorStats[regionName][meteorType] / milion;
                            blackcount += moved;
                            meteorStats[regionName][meteorType] = meteorStats[regionName][meteorType] % (moved * milion);
                            meteorStats[regionName][meteorType] += blackcount;
                        }
                    }
                    else
                    {
                        meteorStats[regionName][meteorType] += count;
                        if (meteorStats[regionName][meteorType] >= milion && meteorType == "Green")
                        {
                            var moved = meteorStats[regionName][meteorType] / milion;
                            redcount += moved;
                            meteorStats[regionName][meteorType] = meteorStats[regionName][meteorType] % (moved * milion);
                            meteorStats[regionName][meteorType] += redcount;
                        }
                        else if (meteorStats[regionName][meteorType] >= milion && meteorType == "Red")
                        {
                            var moved = meteorStats[regionName][meteorType] / milion;
                            blackcount += moved;
                            meteorStats[regionName][meteorType] = meteorStats[regionName][meteorType] % (moved * milion);
                            meteorStats[regionName][meteorType] += blackcount;
                        }
                    }
                }
                
                input = Console.ReadLine();
            }

            foreach (var item in meteorStats.OrderBy(x=>x.Key))
            {
                Console.WriteLine(item.Key);
                foreach (var items in item.Value)
                {
                    Console.WriteLine("-> {0} : {1}",items.Key,items.Value);

                }

            }



        }
    }
}
