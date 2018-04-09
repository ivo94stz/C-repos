using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;


public class MyList<T> : IMyList<T>
    where T : IComparable<T>
{
    public MyList()
    {
        this.data = new T[4];
    }

    private T[] data;

    public int ArraySize => this.data.Length;

    public int Count { get; private set; }

    public T this[int index]
    {
        get
        {
            return this.data[index];
        }
        set
        {
            this.data[index] = value;
        }
    }

    public void Add(T element)
    {
        this.Count++;

        if (this.Count > this.ArraySize)
        {
            T[] newData = new T[ArraySize * 2];
            Array.Copy(data, newData, ArraySize);
            data = newData;
        }
        this.data[this.Count - 1] = element;
    }

    public bool Contains(T element)
    {
        for (int i = 0; i < this.Count; i++)
        {
            if (this.data[i].Equals(element))
            {
                return true;
            }
        }

        return false;
    }

    public int CountGreaterThan(T element)
    {
        int count = 0;
        for (int i = 0; i < this.Count; i++)
        {
            if (this.data[i].CompareTo(element) == 1) count++;
        }

        return count;
    }

    public IEnumerator<T> GetEnumerator()
    {
        throw new NotImplementedException();
    }

    public T Max()
    {
        T max = this.data[0];
        for (int i = 1; i < this.Count; i++)
        {
            if (this.data[i].CompareTo(max) == 1) max = this.data[i];
        }
        return max;
    }

    public T Min()
    {
        T min = this.data[0];
        for (int i = 1; i < this.Count; i++)
        {
            if (this.data[i].CompareTo(min) == -1) min = this.data[i];
        }
        return min;
    }

    public T Remove(int index)
    {
        T element = this.data[index];

        this.Count--;

        for (int i = index; i < this.Count; i++)
        {
            this.data[i] = this.data[i + 1];
        }
        this.data[this.Count] = default(T);

        if (this.Count < this.ArraySize / 3)
        {
            T[] newData = new T[this.ArraySize / 2];
            Array.Copy(this.data, newData, this.Count);
            this.data = newData;
        }

        return element;
    }

    public void Swap(int index1, int index2)
    {
        T temp = this.data[index1];
        this.data[index1] = this.data[index2];
        this.data[index2] = temp;
    }

    public void Sort()
    {
        T temp = this.data[0];
        for (int i = 1; i < this.Count; i++)
        {
            if (this.data[i].CompareTo(temp) == -1)
            {
                T old = this.data[i - 1];
                this.data[i - 1] = this.data[i];
                this.data[i] = old;
                temp = this.data[i];
                i = 0;
            }
            
        }
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        throw new NotImplementedException();
    }
}
