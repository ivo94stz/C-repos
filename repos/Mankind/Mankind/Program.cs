using System;
using System.Linq;

namespace Mankind
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string[] infoStudent = Console.ReadLine().Split();
                string[] infoWorker = Console.ReadLine().Split();


                string studentFirst = infoStudent[0];
                string studentLast = infoStudent[1];
                string studentFaculty = infoStudent[2];
                string workerFirst = infoWorker[0];
                string workerLast = infoWorker[1];
                decimal workerWeek = decimal.Parse(infoWorker[2]);
                decimal workerHours = decimal.Parse(infoWorker[3]);

                var student = new Student(studentFirst, studentLast, studentFaculty);
                var worker = new Worker(workerFirst, workerLast, workerWeek, workerHours);

                Console.WriteLine(student + Environment.NewLine);
                Console.WriteLine(worker);
            }

            catch(ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }
            


        }
    }
}
