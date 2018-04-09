using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Greedy_times
{
    class Program
    {
        static void Main(string[] args)
        {
            long capacity = long.Parse(Console.ReadLine());
            string[] input = Console.ReadLine().Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries).ToArray();

            var goldcapacity = new Dictionary<string, long>();
            var gemcapacity = new Dictionary<string, long>();
            var cashcapacity = new Dictionary<string, long>();
            long quantitygold = 0;
            long quantitygem = 0;
            long quantitycash = 0;
            long quantityall = 0;
            string item = "";

            for (int i = 0; i < input.Length; i+=2)
            {
                long quantity = long.Parse(input[i + 1]);
                item = input[i];


                if (item == "Gold")
                {
                    quantitygold += quantity;
                    quantityall = quantitycash + quantitygem + quantitygold;
                    if (quantityall <= capacity)
                    {
                        if (!goldcapacity.ContainsKey(item))
                        {
                            goldcapacity[item] = quantity;
                        }
                        else
                        {
                            goldcapacity[item] += quantity;
                        }
                    }
                    else
                    {
                        quantityall -= quantitygold;
                        quantitygold -= quantity;
                    }
                }
                else if (item.ToLower().EndsWith("gem"))
                {
                    quantitygem += quantity;
                    quantityall = quantitycash + quantitygem + quantitygold;
                    if (quantityall <= capacity)
                    {
                        if (quantitygem <= quantitygold)
                        {
                            if (!gemcapacity.ContainsKey(item))
                            {
                                gemcapacity[item] = quantity;
                            }
                            else
                            {
                                gemcapacity[item] += quantity;
                            }
                        }
                        else quantitygem -= quantity;
                    }
                    else
                    {
                        quantityall -= quantitygem;
                        quantitygem -= quantity;
                    }
                    
                }
                else if (item.Length == 3)
                {
                    quantitycash += quantity;
                    quantityall = quantitycash + quantitygem + quantitygold;
                    if (quantityall <= capacity)
                    {
                        if (quantitycash <= quantitygem)
                        {
                            if (!cashcapacity.ContainsKey(item))
                            {
                                cashcapacity[item] = quantity;
                            }
                            else
                            {
                                cashcapacity[item] += quantity;
                            }
                        }
                        else quantitycash -= quantity;
                    }
                    else
                    {
                        quantityall -= quantitycash;
                        quantitycash -= quantity;
                    }
                }
                else continue;
                
            }

            if (quantitygold > 0)
            {
                foreach (var items in goldcapacity)
                {
                    Console.WriteLine("<Gold> ${0}",items.Value);
                    Console.WriteLine("##Gold - {0}",items.Value);
                }
            }

            if (quantitygem > 0)
            {
                Console.WriteLine("<Gem> ${0}", quantitygem);
                foreach (var items in gemcapacity.OrderByDescending(x=>x.Key))
                {
                    Console.WriteLine("##{0} - {1}",items.Key,items.Value);
                    
                }
            }

            if (quantitycash > 0)
            {
                Console.WriteLine("<Cash> ${0}", quantitycash);
                foreach (var items in cashcapacity.OrderByDescending(x=>x.Key))
                {
                    Console.WriteLine("##{0} - {1}", items.Key, items.Value);
                    
                }
            }
            
        }
    }
}
