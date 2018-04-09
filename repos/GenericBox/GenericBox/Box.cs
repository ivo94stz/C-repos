using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;


public class Box<T>:IComparable<Box<T>>
    where T:IComparable
{
    public T Value { get; set; }

    public Box(T value)
    {
        this.Value = value;
    }

    public Box()
    {
        this.Value = default(T);
    }

    public List<Box<int>> Swaps(List<Box<int>> boxes, int first , int second)
    {
        var temp = boxes[first];
        boxes[first] = boxes[second];
        boxes[second] = temp;

        return boxes;
    }

    public override string ToString()
    {
        return $"{this.Value.GetType().FullName}: {this.Value}";
    }

    public int CompareTo(Box<T> other)
    {
        return this.Value.CompareTo(other.Value);
    }

    public int GreaterElemnts(List<T> list, double element)
    {
        int count = 0;
        for (int i = 0; i < list.Count; i++)
        {
            if (list[i].CompareTo(element) == 1)
            {
                count++;
            }
        }

        return count;
    }
}
