using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9
{
    class Program
    {
        static void Main(string[] args)
        {
            string alphabet = "abcdefghijklmnopqrstuvwxyz";
            char[] alphas = (alphabet + alphabet.ToLower()).ToCharArray();
            int digit1 = 0;
            int digit2 = 0;

            string input = Console.ReadLine();
            char[] newarr = (input + input.ToLower()).ToArray();
            for (int i = 0; i < newarr.Length/2; i++)
            {
                for (int j = 0; j < alphas.Length/2; j++)
                {
                    if (newarr[i] == alphas[j])
                    {
                        digit1= j;
                        Console.WriteLine("{0} -> {1}", newarr[i], digit1);
                    }
                }
                
            }
            






        }
    }
}
