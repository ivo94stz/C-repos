using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
namespace _2
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            var elements = input.Split(' ').Reverse();
            var stack = new Stack<string>();

            foreach (var item in elements)
            {
                stack.Push(item);
            }
            
            while (stack.Count > 1)
            {
                //Console.WriteLine(stack.Pop());
                int a = int.Parse(stack.Pop());
                var operation = stack.Pop();
                int b = int.Parse(stack.Pop());
                int result = 0;
                if(operation=="-")
                {
                    result = a - b;
                    stack.Push(result.ToString());
                }
                else if(operation == "+")
                {
                    result = a + b;
                    stack.Push(result.ToString());
                }

                Console.WriteLine(stack.Peek());
            }
            
        }
    }
}
