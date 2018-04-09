using System;

namespace OldesetFamiliyMember
{
    class Program
    {
        static void Main(string[] args)
        {
            var family = new Family();
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine().Split();
                var member = new Person(input[0], int.Parse(input[1]));
                family.AddMember(member);
            }
            var oldest = family.GetOldest();
            Console.WriteLine(oldest.Name + ' ' + oldest.Age);
        }
    }
}
