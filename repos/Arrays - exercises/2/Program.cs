using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2
{
    class Program
    {
        static void Main(string[] args)
        {
            var intarr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int rotations = int.Parse(Console.ReadLine());
           

            
            

            int[] newintarr = new int[intarr.Length];

            for (int i = 0; i < rotations; i++)
            {
                int reminder = intarr[intarr.Length - 1];
                for (int j = intarr.Length-1; j > 0; j--)
                {
                    intarr[j] = intarr[j - 1];
                    newintarr[j] += intarr[j];
                }
                intarr[0] = reminder;
                newintarr[0] += intarr[0];
                
                

            }
            Console.WriteLine(string.Join(" ",newintarr));




        }
    }
}
