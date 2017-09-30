using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._11
{
    class Program
    {
        static void Main(string[] args)
        {
            var parola = Console.ReadLine();
            if (parola == "s3cr3t!P@ssw0rd" )
            {
                Console.WriteLine("Welcome");
            }
            else
            {
                Console.WriteLine("Wrong password!");
            }
        }
    }
}
