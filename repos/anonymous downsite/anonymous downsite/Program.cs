using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;
namespace anonymous_downsite
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int key = int.Parse(Console.ReadLine());
            List<string> website = new List<string>();
            decimal totalloss = 0;
            int count = 0;

            for (int i = 0; i < n; i++)
            {
                string[] data = Console.ReadLine().Split(' ').ToArray();
                string sitename = data[0];
                decimal sitevisits = decimal.Parse(data[1]);
                decimal commercialprice = decimal.Parse(data[2]);

                count++;
                website.Add(sitename);
                decimal siteloss = sitevisits * commercialprice;
                totalloss += siteloss;



            }
            for (int i = 0; i < website.Count; i++)
            {
                Console.WriteLine(website[i]);
            }
            Console.WriteLine("Total Loss: {0:f20}", totalloss);
            BigInteger token = key;
            for (int i = 0; i < count-1; i++)
            {
                token = token * key;
            }
            Console.WriteLine("Security Token: {0}",token);

        }
    }
}
