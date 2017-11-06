using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
namespace football_league
{
    class Program
    {
        static void Main(string[] args)
        {
            string key = Console.ReadLine();
            string command = Console.ReadLine();

            string[] tokens = command.Split(' ');
            string decryptedHomeTeam = tokens[0];
            int startIndex = decryptedHomeTeam.IndexOf(key);
            Console.WriteLine(startIndex);
            while (command != "final")
            {
                


                command = Console.ReadLine();
            }
            
        }
    }
}
