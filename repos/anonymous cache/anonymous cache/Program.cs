using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace anonymous_cache
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            List<string> data = new List<string>();
            var dictionary = new Dictionary<string,List< long>>();
            var dictionary1 = new Dictionary<string, List<string>>();
            int count = 1;
            while (input != "thetinggoesskrra")
            {
                data.Add(input);
                input = Console.ReadLine();
            }

            for (int i = 0; i < data.Count; i++)
            {
                string[] line = data[i].Split(new char[] { ' ', '-', '|', '>' }, StringSplitOptions.RemoveEmptyEntries).ToArray();

                string datasets;

                if (line.Length == 1)
                {
                    datasets = line[0];
                    
                    if (!dictionary.ContainsKey(datasets))
                    {
                        dictionary[datasets] = new List<long>();
                    }

                    if (!dictionary1.ContainsKey(datasets))
                    {
                        dictionary1[datasets] = new List<string>();
                    }

                }
                else
                {
                    datasets = line[2];
                    string datakey = line[0];
                    long datasize = long.Parse(line[1]);

                    if (!dictionary.ContainsKey(datasets))
                    {
                        dictionary[datasets] = new List<long>();
                        dictionary[datasets].Add(datasize);
                    }
                    else
                    {
                        dictionary[datasets].Add(datasize);

                    }


                    if (!dictionary1.ContainsKey(datasets))
                    {
                        dictionary1[datasets] = new List<string>();
                        dictionary1[datasets].Add(datakey);
                    }


                    if (!dictionary1[datasets].Contains(datakey))
                    {
                        dictionary1[datasets].Add(datakey);

                    }
                    else continue;
                }


                

            }

            
            foreach (var items in dictionary.OrderByDescending(x => x.Value.Sum()))
            {
                
                Console.WriteLine("Data Set: {0}, Total Size: {1}", items.Key, items.Value.Sum());
                foreach (var item in dictionary1)
                {
                    if (item.Key == items.Key)
                    {
                        for (int i = 0; i < item.Value.Count; i++)
                        {
                            Console.WriteLine("$." + item.Value[i]);
                        }
                        
                    }
                }
                break;
            }


            





        }
    }
}
