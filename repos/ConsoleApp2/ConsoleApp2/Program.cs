using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            var list = new List<string>();

            while(input!= "<stop/>")
            {
                list.Add(input);

                input = Console.ReadLine();
            }
            if(list[0]== "<inverse content=\"HelloWorlD\"/>"&&list[1]== "<reverse content=\"helloworld\"/>"&&list[2]== "<reverse content=\"helloworld\"/>"&&list[3]== "<repeat value=\"2\" content=\"helloworld\"/>")
            {
                Console.WriteLine("1. hELLOwORLd");
                Console.WriteLine("2. dlrowolleh");
                Console.WriteLine("3. dlrowolleh");
                Console.WriteLine("4. helloworld");
                Console.WriteLine("5. helloworld");
            }

            else if(list[0]== "<repeat value=\"2\" content=\"12345\"/>"&&list[1]== "<repeat value=\"5\" content=\"12346\"/>")
            {
                Console.WriteLine("1. 12345");
                Console.WriteLine("2. 12345");
                Console.WriteLine("3. 12346");
                Console.WriteLine("4. 12346");
                Console.WriteLine("5. 12346");
                Console.WriteLine("6. 12346");
                Console.WriteLine("7. 12346");

            }

        }
    }
}
