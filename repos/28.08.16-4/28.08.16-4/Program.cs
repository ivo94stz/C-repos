using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _28._08._16_4
{
    class Program
    {
        static void Main(string[] args)
        {
            var days = int.Parse(Console.ReadLine());
            var docs = 7;
            var yes = 0;
            var no = 0;

            for (int i = 1; i <= days; i++)
            {
                var patients = int.Parse(Console.ReadLine());

                if(patients<= docs)
                {
                    yes = yes + patients;

                }
                else
                {
                    yes = yes + docs;
                    no = no + patients - docs;
                }
                if (i%3 == 2)
                {
                    if (no > yes) docs++;
                }

            }
            Console.WriteLine("Treated patients: {0}.", yes);
            Console.WriteLine("Untreated patients: {0}.",no);
        }
    }
}
