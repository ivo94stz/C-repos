using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MDT_12
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            //IsPalindrome(n);
            int start = 0;
            int end = 0;
            int magic = 0;
            for (int i = 1; i <= n; i++)
            {
                end = i % 10;
                magic = i;
                while (magic>0)
                {
                    if (magic != end)
                    {
                        start = magic % 10;
                        magic = magic / 10;
                    }
                    
                }
                if (start == end) Console.WriteLine(magic);


            }
        //    static void IsPalindrome(int n)
        //{
            
        //    int start = 0;
        //    int end = 0;
            
        //    for (int i = 0; i < n; i++)
        //    {
        //        end = i % 10;
        //        while (i > 0)
        //        {
        //            start = i % 10;
        //            i = i / 10;
        //        }
        //        if (start == end) Console.WriteLine(i);
                
        //    }
            
        }
    }
}
