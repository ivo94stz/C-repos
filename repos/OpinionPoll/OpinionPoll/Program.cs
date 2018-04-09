using System;
using System.Collections.Generic;
using System.Linq;

namespace OpinionPoll
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var people = new List<Person>();
            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine().Split();
                var member = new Person(input[0], int.Parse(input[1]));
                people.Add(member);
            }

            var result = people.Where(p => p.Age > 30).ToList().OrderBy(p => p.Name);

            foreach (var person in result)
            {
                Console.WriteLine("{0} - {1}",person.Name,person.Age);
            }
        }
    }
}
