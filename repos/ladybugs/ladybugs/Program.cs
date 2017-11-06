using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ladybugs
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());
            List<int> indexes = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            int[] output = new int[size];

            for (int i = 0; i < size; i++)
            {
                if (indexes.Contains(i)) output[i] = 1;
                else output[i] = 0;
            }
            var command = Console.ReadLine().Split(' ').ToArray();



            while (command[0] != "end")
            {
                
                int place = int.Parse(command[0]);
                var way = command[1];
                int move = int.Parse(command[2]);
                int newplace = 0;
                if (place + move < size && place + move >= 0)
                {
                    newplace = output[move + place];
                }
                else break;
                


                if (place >= 0 && place < size)
                {
                    if(way == "right")
                    {
                        if (move >= 0)
                        {
                            if (newplace > output.Length)
                            {
                                output[place] = 0;
                            }
                            else
                            {
                                if (newplace == 0)
                                {
                                    output[place] = 0;
                                    newplace = 1;

                                }
                                else
                                {
                                    while (newplace == 1 && place + move <= output.Length)
                                    {

                                        if (newplace == 0)
                                        {
                                            newplace = output[move + place++];
                                            output[place] = 0;
                                            newplace = 1;

                                        }
                                        else
                                        {

                                            output[place] = 0;
                                            newplace = output[move + place++];
                                        }
                                    }


                                }
                            }
                            
                        }
                    }
                }
                




                command = Console.ReadLine().Split(' ').ToArray();
            }
            Console.WriteLine(string.Join(" ",output));

        }
    }
}
