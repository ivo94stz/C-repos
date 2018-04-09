using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sneaking
{
    class Program
    {
        static void Main(string[] args)
        {
            int rows = int.Parse(Console.ReadLine());
            char[][] matrix = new char[rows][];
            int columns = 0;
            int samRow = 0;
            int samCol = 0;
            int nikRow = 0;
            int nikCol = 0;
            bool samIsDeath = false;
            bool nikIsDeath = false;
            int count = 0;


            for (int i = 0; i < matrix.Length; i++)
            {
                char[] inputRow = Console.ReadLine().ToCharArray();
                matrix[i] = new char[rows];
                matrix[i] = inputRow;
                columns = inputRow.Length;
                //    if (inputRow.Contains('b') || inputRow.Contains('d'))
                //    {
                //        enemyRows.Add(i);
                //    }
            }
            var command = Console.ReadLine().ToCharArray();
            for (int m = 0; m < command.Length; m++)
            {
                var step = command[m];
                for (int j = 0; j < rows; j++)
                {
                    for (int k = 0; k < columns; k++)
                    {
                        if (matrix[j][k] == 'd')
                        {
                            if (matrix[j][(k - 1)] == '.' && k - 1 > 0)
                            {
                                matrix[j][(k - 1) % columns] = 'd';
                                matrix[j][k] = '.';
                            }
                            else if ((k - 1) == 0)
                            {
                                matrix[j][k] = 'b';
                            }
                            else continue;
                        }
                        if (matrix[j][k] == 'b')
                        {
                            if (matrix[j][(k + 1)] == '.' && k + 1 < columns - 1)
                            {
                                matrix[j][(k + 1)] = 'b';
                                matrix[j][k] = '.';
                                k++;
                            }
                            else if (k + 1 == columns - 1)
                            {
                                matrix[j][k] = 'd';
                                k++;
                            }
                            else
                            {
                                continue;
                            }
                        }
                        if (step == 'U')
                        {
                            if (samRow-- >= 0)
                            {
                                matrix[samRow][samCol] = 'S';
                                matrix[samRow - 1][samCol] = '.';
                            }
                        }
                        else if (step == 'D')
                        {
                            if (samRow++ <= rows - 1)
                            {
                                matrix[samRow][samCol] = 'S';
                                matrix[samRow + 1][samCol] = '.';
                            }
                        }
                        else if (step == 'L')
                        {
                            if (samCol-- >= 0)
                            {
                                matrix[samRow][samCol] = 'S';
                                matrix[samRow][samCol - 1] = '.';
                            }
                        }
                        else if (step == 'R')
                        {
                            if (samCol++ <= columns - 1)
                            {
                                matrix[samRow][samCol] = 'S';
                                matrix[samRow][samCol + 1] = '.';
                            }
                        }
                        for (int l = 0; l < rows; l++)
                        {
                            for (int f = 0; f < columns; f++)
                            {
                                Console.Write(matrix[l][f]);
                            }
                            Console.WriteLine();
                        }

                    }

                }
            }
                for (int i = 0; i < rows; i++)
                {
                    for (int l = 0; l < columns; l++)
                    {
                        Console.Write(matrix[i][l]);
                    }
                    Console.WriteLine();
                }
                for (int i = 0; i < rows; i++)
                {

                    for (int j = 0; j < columns; j++)
                    {
                        if (matrix[i][j] == 'S')
                        {
                            samRow = i;
                            samCol = j;
                        }
                        else if (matrix[i][j] == 'N')
                        {
                            nikRow = i;
                            nikCol = j;
                        }

                    }
                }
            for (int i = 0; i < command.Length; i++)
            {
                

                for (int p = 0; p < rows; p++)
                {
                    for (int q = 0; q < columns; q++)
                    {
                        if (matrix[p][q] == 'd')
                        {
                            while (count < q)
                            {
                                count++;
                                if (matrix[p][(q - count) % columns] == 'S')
                                {
                                    samIsDeath = true;
                                }
                                
                            }
                            

                        }
                        else if (matrix[p][q] == 'b')
                        {
                            count++;
                            while (count < columns - 1)
                            {
                                
                                if (matrix[p][(q + count) % columns] == 'S')
                                {
                                    samIsDeath = true;
                                }
                                
                            }
                            
                        }
                        
                    }
                    
                }

                
            }
            

        }
    }
}