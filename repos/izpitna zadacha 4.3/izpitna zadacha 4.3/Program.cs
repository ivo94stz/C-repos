using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace izpitna_zadacha_4._3
{
    class Program
    {
        static void Main(string[] args)
        {
            var n1 = double.Parse(Console.ReadLine());
            var n2 = double.Parse(Console.ReadLine());
            var oper = Console.ReadLine();
            var sum = n1 + n2;
            var izv = n1 - n2;
            var umn = n1 * n2;
            var del = Math.Round(n1 / n2,2);
            var ost = n1 % n2;

            if (oper == "+" && sum % 2 == 0) Console.WriteLine("{0} + {1} = {2} - even", n1, n2, sum);
            else if (oper == "+" && sum % 2 != 0) Console.WriteLine("{0} + {1} = {2} - odd", n1, n2, sum);
            else if (oper == "-" && izv % 2 == 0) Console.WriteLine("{0} - {1} = {2} - even", n1, n2, izv);
            else if (oper == "-" && izv % 2 != 0) Console.WriteLine("{0} - {1} = {2} - odd", n1, n2, izv);
            else if (oper == "*" && umn % 2 == 0) Console.WriteLine("{0} * {1} = {2} - even", n1, n2, umn);
            else if (oper == "*" && umn % 2 != 0) Console.WriteLine("{0} * {1} = {2} - odd", n1, n2, umn);
            else if (oper == "/" && n2 != 0) Console.WriteLine("{0} / {1} = {2}", n1, n2, del);
            else if (oper == "/" && n2 == 0) Console.WriteLine("Cannot divide {0} by zero", n1);
            else if (oper == "%" && n2 != 0) Console.WriteLine("{0} % {1} = {2}", n1, n2, ost);
            else if (oper == "%" && n2 == 0) Console.WriteLine("Cannot divide {0} by zero", n1);



        }
    }
}
