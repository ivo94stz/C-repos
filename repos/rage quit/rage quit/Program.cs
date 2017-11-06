using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
namespace rage_quit
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine().ToUpper();
            List<char> words = new List<char>();
            int unique = 0;
            List<char> output = new List<char>();
            int count = 0;

            for (int i = 0; i < input.Length; i++)
            {
                char currchar = input[i];
                
                if (!char.IsNumber(currchar))
                {
                    words.Add(currchar);
                }
                else
                {
                    if (i<input.Length-1&&char.IsNumber(input[i + 1]))
                    {
                        unique = int.Parse(currchar.ToString()+input[i+1]);
                    }
                    else unique = int.Parse(currchar.ToString());
                    
                    for (int j = 0; j < unique; j++)
                    {
                        output.AddRange(words);
                    }
                    words.Clear();
                }
            }
            Console.WriteLine("Unique symbols used: {0}",output.Distinct().Count());
            Console.WriteLine(string.Join("",output));
        }
    }
}
