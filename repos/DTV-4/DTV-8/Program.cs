using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTV_8
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstname = (Console.ReadLine());
            string lastname = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());
            string gender = Console.ReadLine();
            Int64 id = Int64.Parse(Console.ReadLine());
            Int64 unique = Int64.Parse(Console.ReadLine());

            Console.WriteLine("First name: "+firstname);
            Console.WriteLine("Last name: " + lastname);
            Console.WriteLine("Age: " + age);
            Console.WriteLine("Gender: " + gender);
            Console.WriteLine("Personal ID: " + id);
            Console.WriteLine("Unique Employee number: " + unique);


        }
    }
}
