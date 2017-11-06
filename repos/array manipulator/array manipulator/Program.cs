using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace array_manipulator
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> input = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            string[] command = Console.ReadLine().Split(' ').ToArray();
            List<int> output = new List<int>();
            long max = long.MinValue; 
            long min = long.MaxValue;
            
            while (command[0] != "end")
            {
                if (command[0] == "exchange")
                {
                    int index = int.Parse(command[1]);
                    if (index > input.Count - 1 ||index<0)
                    {
                        Console.WriteLine("Invalid index");
                    }
                    else
                    {
                        output.AddRange(input.Skip(index + 1).Take(input.Count - 1 - index));
                        output.AddRange(input.Take(index + 1));
                        for (int i = 0; i < input.Count; i++)
                        {
                            input[i] = output[i];
                        }
                    }
                    //Console.WriteLine(string.Join(" ", output));
                }
                if (command[0] == "max" && command[1] == "odd")
                {
                    for (int i = 0; i < input.Count; i++)
                    {
                        output.Add(input[i]);
                    }
                    if (input.Count < 1) Console.WriteLine("No matches");
                    else
                    {
                        for (int i = 0; i < output.Count; i++)
                        {
                            if (output[i] % 2 != 0&&output[i]>=max)
                            {
                                for (int j = 0; j < i; j++)
                                {
                                    output[j] = 0;
                                }
                                max = output[i];
                            }
                           else
                            {
                                output[i] = 0;
                            }
                        }
                    }
                    if (output.Max() == 0) Console.WriteLine("No matches");
                    else  Console.WriteLine(output.IndexOf(output.Max()));
                }
                else if (command[0] == "min" && command[1] == "odd")
                {
                    for (int i = 0; i < input.Count; i++)
                    {
                        output.Add(input[i]);
                    }
                    if (input.Count < 1) Console.WriteLine("No matches");
                    else
                    {
                        for (int i = 0; i < output.Count; i++)
                        {
                            if (output[i] % 2 != 0 && output[i] <= min)
                            {
                                for (int j = 0; j < i; j++)
                                {
                                    output[j] = 0;
                                }
                                min = output[i];
                            }
                            else
                            {
                                output[i] = 0;
                            }
                        }
                    }
                    if (output.Max() == 0) Console.WriteLine("No matches");
                    else Console.WriteLine(output.IndexOf(output.Max()));
                }
                if (command[0] == "max" && command[1] == "even")
                {
                    for (int i = 0; i < input.Count; i++)
                    {
                        output.Add( input[i]);
                    }
                    if (input.Count < 1) Console.WriteLine("No matches");
                    else
                    {
                        for (int i = 0; i < output.Count; i++)
                        {
                            if (output[i] % 2 == 0 && output[i] >= max)
                            {
                                for (int j = 0; j < i; j++)
                                {
                                    output[j] = 0;
                                }
                                max = output[i];
                            }
                            else
                            {
                                output[i] = 0;
                            }
                        }
                    }
                    if (output.Max() == 0) Console.WriteLine("No matches");
                    else Console.WriteLine(output.IndexOf(output.Max()));

                }
                else if (command[0] == "min" && command[1] == "even")
                {
                    for (int i = 0; i < input.Count; i++)
                    {
                        output.Add(input[i]);
                    }
                    if (input.Count < 1) Console.WriteLine("No matches");
                    else
                    {
                        for (int i = 0; i < output.Count; i++)
                        {
                            if (output[i] % 2 == 0 && output[i] <= min)
                            {
                                for (int j = 0; j < i; j++)
                                {
                                    output[j] = 0;
                                }
                                min = output[i];
                            }
                            else
                            {
                                output[i] = 0;
                            }
                        }
                    }
                    if (output.Max() == 0) Console.WriteLine("No matches");
                    else Console.WriteLine(output.IndexOf(output.Max()));

                }
                else if (command[0] == "first" && command[2] == "even")
                {
                    int index = int.Parse(command[1]);
                    if (index > input.Count||index<0) Console.WriteLine("Invalid count");
                    else
                    {
                        for (int i = 0; i < input.Count; i++)
                        {
                            if (input[i] % 2 == 0 && input[i] > 0)
                            {
                                output.Add(input[i]);
                            }
                            if (output.Count == index) break;
                        }
                        Console.WriteLine("[" + string.Join(", ", output) + "]");
                    }
                }
                else if (command[0] == "first" && command[2] == "odd")
                {
                    int index = int.Parse(command[1]);
                    if (index > input.Count || index < 0) Console.WriteLine("Invalid count");
                    else
                    {
                        for (int i = 0; i < input.Count; i++)
                        {
                            if (input[i] % 2 != 0 && input[i] > 0)
                            {
                                output.Add(input[i]);
                            }
                            if (output.Count == index) break;
                        }
                        Console.WriteLine("[" + string.Join(", ", output) + "]");
                    }
                }
                else if (command[0] == "last" && command[2] == "odd")
                {
                    int index = int.Parse(command[1]);
                    if (index > input.Count || index < 0) Console.WriteLine("Invalid count");
                    else
                    {
                        for (int i = 0; i < input.Count; i++)
                        {
                            if (input[i] % 2 != 0 && input[i] > 0)
                            {
                                output.Add(input[i]);
                            }
                        }
                        Console.WriteLine("[" + string.Join(", ", output.Skip(output.Count-index).Take(index)) + "]");
                    }
                }
                else if (command[0] == "last" && command[2] == "even")
                {
                    int index = int.Parse(command[1]);
                    if (index > input.Count || index < 0) Console.WriteLine("Invalid count");
                    else
                    {
                        for (int i = 0; i < input.Count; i++)
                        {
                            if (input[i] % 2 == 0 &&input[i]>0)
                            {
                                output.Add(input[i]);
                            }
                        }
                        Console.WriteLine("[" + string.Join(", ", output.Skip(output.Count-index).Take(index)) + "]");
                    }
                }
                command = Console.ReadLine().Split(' ').ToArray();
                max = int.MinValue;
                min = int.MaxValue;
                output.Clear();
            }
            Console.WriteLine("["+string.Join(", ",input)+"]");



        }
    }
}