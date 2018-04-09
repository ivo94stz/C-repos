using System;

namespace CustomList
{
    class Program
    {
        static void Main(string[] args)
        {
            MyList<string> list = new MyList<string>();

            string command;
           while((command = Console.ReadLine())!= "END")
            {
                string[] info = command.Split();
                string first = info[0];

                switch (first)
                {
                    case "Add":
                        list.Add(info[1]);
                        break;
                    case "Remove":
                        list.Remove(int.Parse(info[1]));
                        break;
                    case "Contains":
                        bool result = list.Contains(info[1]);
                        Console.WriteLine(result);
                        break;
                    case "Swap":
                        list.Swap(int.Parse(info[1]), int.Parse(info[2]));
                        break;
                    case "Greater":
                        int countGreater =  list.CountGreaterThan(info[1]);
                        Console.WriteLine(countGreater);
                        break;
                    case "Max":
                        string max = list.Max();
                        Console.WriteLine(max);
                        break;
                    case "Min":
                        string min = list.Min();
                        Console.WriteLine(min);
                        break;
                    case "Print":
                        for (int i = 0; i < list.Count; i++)
                        {
                            Console.WriteLine(list[i]);
                        }
                        break;
                    case "Sort":
                        list.Sort();
                        break;
                    default:
                        break;
                }
            }
           
        }
    }
}
