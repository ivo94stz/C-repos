using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace anonymous_threat
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> input = Console.ReadLine().Split(' ').ToList();
            List<string> newlist = new List<string>();
            string move = "";


            while (move != "3:1")
            {
                List<string> command = Console.ReadLine().Split(' ').ToList();
                 move = command[0];
                

                if (move == "merge")
                {
                    int start = int.Parse(command[1]);
                    int end = int.Parse(command[2]);
                    if (start < 0) start = 0;
                    if (end > input.Count-1 ) end = input.Count-1 ;
                    if (start >= input.Count - 1) start = input.Count - 2;
                    if (end <= 0) end = 1;

                    List<string> input1 = new List<string>();
                    for (int i = 0; i < input.Count; i++)
                    {
                        input1.Add(input[i]);
                    }

                    string newstr = input[start];

                    for (int i = start+1; i < end+1; i++)
                    {
                        newstr += input1[i];
                        
                    }
                    input1.RemoveRange(start, end+1);
                    //Console.WriteLine(string.Join(" ", input1));
                    newlist.Add(newstr);
                    newlist.AddRange(input1);
                    //Console.WriteLine(string.Join(" ", newlist));

                    //Console.WriteLine(newstr);
                    //Console.WriteLine(input1[0]);
                    //Console.WriteLine(string.Join(" ",newlist));
                    input.Clear();
                    for (int i = 0; i < newlist.Count; i++)
                    {
                        input.Add(newlist[i]);
                    }
                }
                
                else if(move == "divide")
                {
                    int index = int.Parse(command[1]);
                    int partitions = int.Parse(command[2]);
                    string start = input[index];
                    string newstr;

                    int exactly = start.Length % partitions;
                    if (exactly == 0)
                    {
                        int count = start.Length / partitions;
                        for (int i = 0; i < partitions; i++)
                        {
                            newstr = start.Substring(i * count, count);
                            newlist.Add(newstr);
                        }
                        Console.WriteLine(string.Join(" ",newlist));
                        
                    }
                    else
                    {
                        int count = start.Length / partitions;
                        int countlast = count + (start.Length % partitions);

                        for (int i = 0; i < partitions; i++)
                        {
                            if (i == partitions - 1)
                            {
                                newstr = start.Substring(i * count, countlast);
                                newlist.Add(newstr);

                            }
                            else
                            {
                                newstr = start.Substring(i * count, count);
                                newlist.Add(newstr);
                            }
                            Console.WriteLine(string.Join(" ", newlist));
                        }
                        Console.WriteLine(string.Join(" ", newlist));


                    }

                    
                }
                Console.WriteLine(string.Join(" ", newlist));


            }
            //Console.WriteLine(string.Join(" ", newlist));
            Console.WriteLine();

        }
    }
}
