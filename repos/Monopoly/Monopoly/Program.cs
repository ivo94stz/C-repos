using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Monopoly
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] demensions = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int rows = demensions[0];
            int columns = demensions[1];
            var matrix = new char[rows, columns];
            long money = 50;
            int turns = 0;
            long earnedMoney = 0;


            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                var line = Console.ReadLine().ToCharArray();


                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = line[col];
                }
            }

            int currentRow = 0;
            int currentCol = 0;
            int hotels = 0;

            while(currentRow <= rows-1 && currentCol <= columns-1)
            {
                
                
                
                if (matrix[currentRow, currentCol] == 'H')
                {
                    hotels++;
                    Console.WriteLine("Bought a hotel for {0}. Total hotels: {1}.",money ,hotels);
                    money = 0;
                    
                }
                else if (matrix[currentRow, currentCol] == 'J')
                {
                    Console.WriteLine("Gone to jail at turn {0}.",turns);
                    turns += 2;
                    money += 10 * hotels*2;
                }
                else if (matrix[currentRow, currentCol] == 'S')
                {
                   long spendMoney = Math.Min((currentRow + 1) * (currentCol + 1), money);
                    money -= spendMoney;
                    Console.WriteLine("Spent {0} money at the shop.",spendMoney);
                }

                if (currentRow == 0 || currentRow % 2 == 0)
                {
                    currentCol++;
                    if (currentCol > columns-1)
                    {
                        currentCol = columns - 1;
                        currentRow++;
                    }
                }
                else if (currentRow % 2 != 0)
                {
                    currentCol--;
                    if (currentCol < 0)
                    {
                        currentCol = 0;
                        currentRow++;
                    }
                }
                earnedMoney = hotels * 10;
                money += earnedMoney;
                turns++;
            }
            Console.WriteLine("Turns {0}",turns);
            Console.WriteLine("Money {0}",money);


        }
    }
}
