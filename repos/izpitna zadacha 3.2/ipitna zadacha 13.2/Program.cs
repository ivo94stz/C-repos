using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ipitna_zadacha_13._2
{
    class Program
    {
        static void Main(string[] args)
        {
            var V = int.Parse(Console.ReadLine());
            var P1 = int.Parse(Console.ReadLine());
            var P2 = int.Parse(Console.ReadLine());
            var H = double.Parse(Console.ReadLine());
            var sum = (P1 * H + P2 * H) - V;
            var percent = Math.Floor(((P1 * H + P2 * H) / V) * 100);
            var P1percent = Math.Floor((P1 * H) / (P1 * H + P2 * H) * 100);
            var P2percent = Math.Floor((P2 * H) / (P1 * H + P2 * H) * 100);

            if ((P1 * H + P2 * H) > V) Console.WriteLine("For {0} hours the pool overflows with {1} liters. ", H, sum);
            else if ((P1 * H + P2 * H) < V) Console.WriteLine("The pool is {0}% full. Pipe 1: {1}%. Pipe 2: {2}%.", percent, P1percent, P2percent);

        }
    }
}
