using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace command_interpreter
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> input = Console.ReadLine().Split(new char
                [] { ' ' },StringSplitOptions.RemoveEmptyEntries ).ToList();

            List<string> commands = Console.ReadLine().Split(new char
                [] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToList();
            string[] arr = new string[input.Count].ToArray();
            List<string> arr1 = new string[input.Count].ToList();


            while (commands[0] != "end")
            {
                for (int i = 0; i < arr.Length; i++)
                {
                    arr[i] = input[i];
                }
                long startn = 0;
                long countn = 0;
                if (commands[0] == "reverse" || commands[0] == "sort")
                {
                    startn = long.Parse(commands[2]);
                    countn = long.Parse(commands[4]);
                    if (startn < 0 || startn > input.Count - 1 || countn + startn > input.Count || countn < 0)
                    {
                        Console.WriteLine("Invalid input parameters.");
                    }
                    int end = 0;
                    int start = 0;
                    int count = 0;
                    if (commands[0] == "reverse" && int.Parse(commands[2]) >= 0 && int.Parse(commands[2]) < arr.Length && int.Parse(commands[4]) >= 0 && int.Parse(commands[4]) < int.MaxValue)
                    {
                        for (int i = 0; i < arr.Length; i++)
                        {
                            arr1[i] = arr[i];
                        }
                        end = int.Parse(commands[4]);
                        start = int.Parse(commands[2]);
                        count = int.Parse(commands[4]);
                        for (int i = start; i < start + end; i++)
                        {
                            arr[i] = arr1[start + count - 1];
                            count--;
                        }
                    }
                    else if (commands[0] == "sort" && int.Parse(commands[2]) >= 0 && int.Parse(commands[2]) < arr.Length && int.Parse(commands[4]) >= 0 && int.Parse(commands[4]) < int.MaxValue)
                    {
                        end = int.Parse(commands[4]);
                        start = int.Parse(commands[2]);
                        count = int.Parse(commands[4]);
                        for (int i = start; i < start + end; i++)
                        {
                            arr1[i] = arr[i];
                        }
                        arr1.Sort();
                        arr1.Reverse();
                        for (int i = start; i < start + end; i++)
                        {
                            arr[i] = arr1[count - 1];
                            count--;
                        }
                    }
                }


                else 
                {
                    countn = long.Parse(commands[1]);

                    if (countn < 0)
                    {
                        Console.WriteLine("Invalid input parameters.");
                    }
                    int end = 0;
                    int start = 0;
                    int count = 0;
                    if (commands[0] == "rollLeft" && int.Parse(commands[1]) >= 0 && int.Parse(commands[1]) < int.MaxValue)
                    {
                        int rolls = int.Parse(commands[1]);
                        while (rolls != 0)
                        {
                            for (int i = 0; i < arr.Length; i++)
                            {
                                arr1[i] = arr[i];
                            }
                            count = 1;
                            for (int i = arr.Length - 2; i >= 0; i--)
                            {
                                arr[i] = arr1[arr1.Count - count];
                                count++;
                            }
                            arr[arr.Length - 1] = arr1[0];
                            rolls--;
                        }

                    }
                    else if (commands[0] == "rollRight" && int.Parse(commands[1]) >= 0 && int.Parse(commands[1]) < int.MaxValue)
                    {
                        int rolls = int.Parse(commands[1]);
                        while (rolls != 0)
                        {
                            for (int i = 0; i < arr.Length; i++)
                            {
                                arr1[i] = arr[i];
                            }
                            count = 0;
                            for (int i = 1; i < arr.Length; i++)
                            {
                                arr[i] = arr1[count];
                                count++;
                            }
                            arr[0] = arr1[arr.Length - 1];
                            rolls--;
                        }

                    }
                }

                    
                
                commands = Console.ReadLine().Split(new char
                [] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToList();
            }

            Console.WriteLine("["+string.Join(", ",arr)+"]");
            
        }
    }
}
