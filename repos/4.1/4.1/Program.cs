using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4._1
{
    class Program
    {
        static void Main(string[] args)
        {
            var age = double.Parse(Console.ReadLine());
            var gender = Console.ReadLine().ToLower();

            if (gender == "f") 
            {
                if (age < 16) Console.WriteLine("Miss");
                else Console.WriteLine("Ms.");
            } 
            else if (gender == "m")
            {
                if (age < 16) Console.WriteLine("master");
                else Console.WriteLine("Mr.");
            }
            
        }
    }
}
