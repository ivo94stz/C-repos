using System;
using System.Collections.Generic;
using System.Text;


public class Matrix
{
    public int x;
    public int y;

    public Matrix(int x,int y )
    {
        this.x = x;
        this.y = y;
        int[,] field = new int[x, y];
        int value = 0;
        for (int i = 0; i < x; i++)
        {
            for (int j = 0; j < y; j++)
            {
                field[i, j] = value++;
            }
        }
    }
    
}
   
