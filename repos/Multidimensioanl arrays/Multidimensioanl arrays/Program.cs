using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multidimensioanl_arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] rowsandcolumns = Console.ReadLine().Split(new string[] { ", "},StringSplitOptions.None).Select(int.Parse).ToArray();
            int[,] matrix = new int[rowsandcolumns[0], rowsandcolumns[1]];
            for (int i = 0; i < rowsandcolumns[0]; i++)
            {
                var values = Console.ReadLine().Split(new string[] { ", " }, StringSplitOptions.None).Select(int.Parse).ToArray();
                for (int j = 0; j < rowsandcolumns[1]; j++)
                {
                    matrix[i, j] = values[j];
                }
            }
            int sum = 0;
            for (int rows = 0; rows < matrix.GetLength(0); rows++)
            {
                for (int columns = 0; columns < matrix.GetLength(1); columns++)
                {
                    sum += matrix[rows, columns];
                }
            }


            Console.WriteLine(matrix.GetLength(0));
            Console.WriteLine(matrix.GetLength(1));
            Console.WriteLine(sum);
        }
    }
}
