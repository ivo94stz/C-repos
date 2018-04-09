using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hit_list
{
    class Program
    {
        static void Main(string[] args)
        {
            int targetIndex = int.Parse(Console.ReadLine());
            var input = Console.ReadLine();
            var key = "";
            var value = "";
            var output = new Dictionary<string, Dictionary<string, string>>();

            while (input!= "end transmissions")
            {
                var data = input.Split('=').ToArray();
                var name = data[0];
                var info = data[1].Split(';').ToArray();
                

                for (int i = 0; i < info.Length; i++)
                {
                    var keyValue = info[i].Split(':').ToArray();
                    key = keyValue[0];
                    value = keyValue[1];

                    if (!output.ContainsKey(name))
                    {
                        output[name] = new Dictionary<string, string>();
                        if (!output[name].ContainsKey(key))
                        {
                            output[name][key] = value;
                        }
                        else
                        {
                            output[name][key] = value;
                        }
                    }
                    else
                    {
                        if (!output[name].ContainsKey(key))
                        {
                            output[name][key] = value;
                        }
                        else
                        {
                            output[name][key] = value;
                        }
                    }
                    
                }

                input = Console.ReadLine();
            }

            var killed = Console.ReadLine().Split(new[] { "Kill "},StringSplitOptions.RemoveEmptyEntries).ToArray();
            var target = killed[0];
            int infoIndex = 0;
            Console.WriteLine("Info on {0}:", target);
            foreach (var item in output)
            {
                if (item.Key == target)
                {
                    foreach (var items in item.Value.OrderBy(x=>x.Key))
                    {
                        Console.WriteLine("---{0}: {1}", items.Key, items.Value);
                        infoIndex += items.Key.Length + items.Value.Length;
                    }

                }

            }
            Console.WriteLine("Info index: {0}",infoIndex);
            if (infoIndex >= targetIndex) Console.WriteLine("Proceed");
            else
            {
                Console.WriteLine("Need {0} more info.", targetIndex-infoIndex);
            }
        }
    }
}
