using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Times_since_birthday
{
    class Program
    {
        static void Main(string[] args)
        {
            int years = int.Parse(Console.ReadLine());
            int days = years * 365;
            long hours = days * 24;
            long mins = hours * 60;
            Console.WriteLine($"{years} years = {days} days = {hours} hours = {mins} minutes.");


        }
    }
}
