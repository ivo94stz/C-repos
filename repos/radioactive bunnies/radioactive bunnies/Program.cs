using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace radioactive_bunnies
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] demensions = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int rows = demensions[0];
            int columns = demensions[1];
            var matrix = new char[rows, columns];


            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                var line = Console.ReadLine().ToCharArray();


                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = line[col];
                }
            }

            var command = Console.ReadLine().ToCharArray();

            int currentRowP = 0;
            int currentColP = 0;
            bool win = false;
            bool dead = false;
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    if (matrix[i, j] == 'P')
                    {
                        currentColP = j;
                        currentRowP = i;
                    }
                }
            }
            
            for (int i = 0; i < command.Length; i++)
            {
                var list = new List<int>();
                for (int b1 = 0; b1 < rows; b1++)
                {
                    for (int b2 = 0; b2 < columns; b2++)
                    {
                        if (matrix[b1, b2] == 'B')
                        {
                            if (b2 + 1 < columns)
                            {
                                list.Add(b1);
                                list.Add(b2 + 1);
                            }
                            if (b2 - 1 >= 0)
                            {
                                list.Add(b1);
                                list.Add(b2 - 1);
                            }
                            if (b1 + 1 < rows)
                            {
                                list.Add(b1 + 1);
                                list.Add(b2);
                            }
                            if (b1 - 1 >= 0)
                            {
                                list.Add(b1 - 1);
                                list.Add(b2);
                            } 
                        }
                    }
                }
                for (int q = 0; q < list.Count; q+=2)
                {
                    matrix[list[q],list[q+1]] = 'B';
                }

                if (command[i] == 'U')
                {
                    if (matrix[currentRowP, currentColP] != 'B')
                    {
                        matrix[currentRowP, currentColP] = '.';
                    }
                    
                    
                    
                    if (currentRowP - 1 < 0)
                    {
                        win = true;
                        break;
                        
                    }
                    else if (matrix[currentRowP - 1, currentColP] == 'B')
                    {
                        currentRowP -= 1;
                        dead = true;
                        break;
                    }
                    else
                    {
                        matrix[currentRowP - 1, currentColP] = 'P';
                        currentRowP -= 1;
                    }
                }
                else if (command[i] == 'D')
                {
                    if (matrix[currentRowP, currentColP] != 'B')
                    {
                        matrix[currentRowP, currentColP] = '.';
                    }

                    if (currentRowP + 1 > rows-1)
                    {
                        win = true;
                        break;
                        
                    }
                    else if (matrix[currentRowP + 1, currentColP] == 'B')
                    {
                        currentRowP += 1;
                        dead = true;
                        break;
                    }
                    else
                    {
                        matrix[currentRowP + 1, currentColP] = 'P';
                        currentRowP += 1;
                    }
                }
                else if (command[i] == 'L')
                {
                    if (matrix[currentRowP, currentColP] != 'B')
                    {
                        matrix[currentRowP, currentColP] = '.';
                    }

                    if (currentColP - 1 < 0)
                    {
                        win = true;
                        break;
                    }
                    else if (matrix[currentRowP, currentColP - 1] == 'B')
                    {
                        currentColP -= 1;
                        dead = true;
                        break;
                    }
                    else
                    {
                        matrix[currentRowP , currentColP-1] = 'P';
                        currentColP -= 1;
                    }
                    
                }
                if (command[i] == 'R')
                {
                    if (matrix[currentRowP, currentColP] != 'B')
                    {
                        matrix[currentRowP, currentColP] = '.';
                    }

                    if (currentColP + 1 > columns-1)
                    {
                        win = true;
                        break;
                    }
                    else if (matrix[currentRowP, currentColP + 1] == 'B')
                    {
                        currentColP += 1;
                        dead = true;
                        break;
                    }
                    else
                    {
                        matrix[currentRowP, currentColP+1] = 'P';
                        currentColP += 1;
                    }
                }

                if (win == true) break;
                if (dead == true) break;
            }

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.Write(matrix[i,j]);
                }
                Console.WriteLine();
            }
            if (win == true) Console.WriteLine("won: {0} {1}",currentRowP,currentColP);
            else Console.WriteLine("dead: {0} {1}",currentRowP,currentColP);

        }
    }
}
