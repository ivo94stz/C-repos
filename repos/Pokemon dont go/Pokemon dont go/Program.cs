using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemon_dont_go
{
    class Program
    {
        static void Main(string[] args)
        {
            List<long> input = Console.ReadLine().Split(' ').Select(long.Parse).ToList();

            
            long remove = 0;
            long sum = 0;
                
            while (input.Count > 0)
            {
                int index = int.Parse(Console.ReadLine());

                if (index < 0)
                {
                    remove = input[0];
                    sum += remove;
                    input[0] = input[input.Count - 1];
                    for (int j = 0; j < input.Count; j++)
                    {
                        if (input[j] <= remove)
                        {
                            input[j] += remove;
                        }
                        else input[j] -= remove;
                    }

                }
                else if (index >= input.Count)
                {
                    remove = input[input.Count - 1];
                    sum += remove;
                    input[input.Count - 1] = input[0];
                    for (int j = 0; j < input.Count; j++)
                    {
                        if (input[j] <= remove)
                        {
                            input[j] += remove;
                        }
                        else input[j] -= remove;
                    }
                    
                    //index = int.Parse(Console.ReadLine());
                }
                else
                {
                    remove = input[index];
                    sum += remove;
                    input.RemoveAt(index);

                    for (int j = 0; j < input.Count; j++)
                    {
                        if (input[j] <= remove)
                        {
                            input[j] += remove;
                        }
                        else input[j] -= remove;
                    }
                    //index = int.Parse(Console.ReadLine());
                }



                remove = 0;

                //Console.WriteLine(string.Join(" ", input));

            }


            Console.WriteLine(sum);

        }
    }
}
