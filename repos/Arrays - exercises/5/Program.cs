using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] arr1 = Console.ReadLine().Split(' ').Select(char.Parse).ToArray();
            char[] arr2 = Console.ReadLine().Split(' ').Select(char.Parse).ToArray();
            var min = Math.Min(arr1.Length, arr2.Length);
            int count = 0;
            bool same = false;
            if (arr1[0] < arr2[0])
            {
                Console.WriteLine(string.Join("", arr1));
                Console.WriteLine(string.Join("", arr2));
            }
            else if (arr1[0] > arr2[0])
            {
                Console.WriteLine(string.Join("", arr2));
                Console.WriteLine(string.Join("", arr1));
            }
            for (int i = 0; i < min; i++)
            {
                if (arr1[i] == arr2[i]) same = true;
            }
            if (same == true)
            {
                Console.WriteLine(string.Join("", arr1));
                Console.WriteLine(string.Join("", arr2));
            }

            else if (arr1[0] == arr2[0])
            {
                while (arr1[count] == arr2[count])
                {
                    
                    if (arr1[count] < arr2[count])
                    {
                        Console.WriteLine(string.Join("", arr1));
                        Console.WriteLine(string.Join("", arr2));
                    }
                    else if (arr1[count] > arr2[count])
                    {
                        Console.WriteLine(string.Join("", arr2));
                        Console.WriteLine(string.Join("", arr1));
                    }
                    count++;
                }
                


                
            }
            

        

        }
    }
}
