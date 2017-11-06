using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace portal
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());
            string lines = "";
            List<string> matrix = new List<string>();
            int startcol = 0;
            int finishcol = 0;
            int startrow = 0;
            int finishrow = 0;

            for (int i = 0; i < size; i++)
            {
                lines = Console.ReadLine();
                matrix.Add(lines);
            }
            string command = Console.ReadLine();

            for (int i = 0; i < matrix.Count; i++)
            {
                if (matrix[i].Contains("S"))
                {
                    startcol = matrix[i].IndexOf('S');
                    startrow = i;
                    //Console.WriteLine(i + " " + startcol);
                }
                else if (matrix[i].Contains("E"))
                {
                    finishcol = matrix[i].IndexOf('E');
                    finishrow = i;
                    //Console.WriteLine(i + " " + finishcol);
                }
            }
            for (int i = 0; i < command.Length; i++)
            {
                if (command[i] == 'D')
                {
                    startrow++;
                    if (startrow > matrix.Count - 1) startrow = 0;
                    while (matrix[startrow].Count() - 1 < startcol)
                    {
                        startrow++;
                        if (startrow > matrix.Count - 1) startrow = 0;
                    }
                    
                }
                if (command[i] == 'U')
                {
                    startrow--;
                    if (startrow < 0) startrow = matrix.Count-1;
                    while (matrix[startrow].Count() - 1 < startcol)
                    {
                        startrow--;
                        if(startrow<0) startrow = matrix.Count - 1;
                    }
                    
                }
                if (command[i] == 'L')
                {
                    startcol--;
                    if (startcol < 0) startcol =matrix[startrow].Count() - 1;
                    //if (matrix[startrow].Count() - 1 < startcol) startrow--;
                }
                if (command[i] == 'R')
                {
                    startcol++;
                    if (startcol > matrix[startrow].Count() - 1) startcol = 0;
                    //if (matrix[startrow].Count() - 1 < startcol) startrow--;
                }


                if (startrow == finishrow && startcol == finishcol)
                {
                    Console.WriteLine("Experiment successful. {0} turns required.", i + 1);
                    break;
                }
                //Console.WriteLine("Robot stuck at {0} {1}. Experiment failed.", startrow, startcol);
            }
                if (startrow != finishrow || startcol != finishcol)
            {
                Console.WriteLine("Robot stuck at {0} {1}. Experiment failed.", startrow, startcol);
            }

                
            

        }
    }
}
