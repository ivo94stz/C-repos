using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IBS._5
{
    class Program
    {
        static void Main(string[] args)
        {
            var name = Console.ReadLine();
            var currenthealth = int.Parse(Console.ReadLine());
            var maxhealth = int.Parse(Console.ReadLine());
            var currentenergy = int.Parse(Console.ReadLine());
            var maxenergy = int.Parse(Console.ReadLine());


            Console.WriteLine("Name: {0}",name);

            Console.Write("Health: |");
            for (int i = 1; i <= maxhealth; i++)
            {
               
                if (i <= currenthealth) Console.Write("|");
                else Console.Write("."); 
                
                
            }
            Console.Write('|');
            Console.WriteLine();
            Console.Write("Energy: |");
            for (int i = 1; i <= maxenergy; i++)
            {
                
                if (i <= currentenergy) Console.Write("|");
                else Console.Write(".");
                
                
            }
            Console.Write('|');
            Console.WriteLine();
        }
    }
}
