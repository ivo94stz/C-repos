using System;
using System.Collections.Generic;
using System.Text;


public class Box
{
    double length;
    double width;
    double height;
    

    

    public double Length
    {
        get { return length; }
        private set
        {
            if (value <= 0)
            {
                throw new ArgumentException("Length cannot be zero or negative.");
            }
            else
            {
                length = value;
            }
        }
    }
    public double Width
    {
        get { return width; }
        private set {
            if (value <= 0)
            {
                throw new ArgumentException("Width cannot be zero or negative.");
            }
            else
            {
                width = value;
            }
        }
    }
    public double Height
    {
        get { return height; }
        
        private set {
            if (value <= 0)
            {
                throw new ArgumentException("Height cannot be zero or negative.");
            }
            else
            {
                height = value;
            }
            }
    }

    public Box(double length, double width, double height)
    {
        Length = length;
        Width = width;
        Height = height;

    }

    public double SurvfaceArea()
    {
        return  2 * Length * Width + 2 * Length * Height + 2 * Width * Height;
    }
    public double LeterealSurfaceArea()
    {
        return 2 * Length * Height + 2 * Width * Height;
    }
    public double Volume()
    {
        return Length * Width * Height;
    }

    
    

}

