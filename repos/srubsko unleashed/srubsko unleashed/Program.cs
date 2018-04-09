using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace srubsko_unleashed
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            bool format = true;
            bool isDigit = true;
            var output = new Dictionary<string, Dictionary<string, ulong>>();

            while (input != "End")
            {
                format = true;
                isDigit = true;
                
                var info = input.Split(new[] { " @"},StringSplitOptions.RemoveEmptyEntries).ToArray();
                if (info.Length != 2)
                {
                    format = false;
                }
                if (format == true)
                {
                    string singer = info[0];
                    var data = info[1].Split(' ').Reverse().ToArray();
                    ulong ticketsCount = 0;
                    ulong ticketsPrice = 0;
                    string town = "";

                    for (int i = 0; i < data[1].Length; i++)
                    {
                        if (!char.IsDigit(data[1][i]))
                        {
                            isDigit = false;
                            break;
                        }
                    }
                    if (isDigit == true)
                    {
                        ticketsCount = ulong.Parse(data[0]);
                        ticketsPrice = ulong.Parse(data[1]);


                        for (int i = data.Length - 1; i > 1; i--)
                        {
                            if (i == 2) town += data[i];
                            else town += data[i] + ' ';
                        }
                    }
                    if (format == true && isDigit == true)
                    {
                        if (!output.ContainsKey(town))
                        {
                            output[town] = new Dictionary<string, ulong>();
                            if (!output[town].ContainsKey(singer))
                            {
                                output[town][singer] = ticketsCount * ticketsPrice;
                            }
                            else
                            {
                                output[town][singer] += ticketsCount * ticketsPrice;
                            }

                        }
                        else
                        {
                            if (!output[town].ContainsKey(singer))
                            {
                                output[town][singer] = ticketsCount * ticketsPrice;
                            }
                            else
                            {
                                output[town][singer] += ticketsCount * ticketsPrice;
                            }
                        }


                    }

                }





                input = Console.ReadLine();
            }

            foreach (var item in output)
            {
                Console.WriteLine(item.Key);
                foreach (var items in item.Value.OrderByDescending(x=>x.Value))
                {
                    Console.WriteLine("#  {0} -> {1}",items.Key,items.Value);
                }
            }



        }
    }
}
