using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18._12._16_3
{
    class Program
    {
        static void Main(string[] args)
        {
            var hriz = double.Parse(Console.ReadLine());
            var rose = double.Parse(Console.ReadLine());
            var lale = double.Parse(Console.ReadLine());
            var season = Console.ReadLine();
            var praznik = Console.ReadLine();

            var Ph1 = 2.00 * hriz;
            var Pr1 = 4.10 * rose;
            var Pl1 = 2.50 * lale;

            var Ph2 = 3.75 * hriz;
            var Pr2 = 4.50 * rose;
            var Pl2 = 4.15 * lale;

            var P1 = Ph1 + Pr1 + Pl1;
            var P2 = Ph2 + Pr2 + Pl2;



            if (season == "Spring" || season == "Summer")
            {
                if (praznik == "Y")
                {
                    P1 = P1 + P1 * 0.15;
                    if (lale > 7)
                    {
                        P1 = P1 - P1 * 0.05;
                        if (hriz + rose + lale > 20) P1 = P1 - P1 * 0.2;
                    }
                }
                else if (praznik == "N")
                {
                    if (lale > 7)
                    {
                        P1 = P1 - P1 * 0.05;
                        if (hriz + rose + lale > 20) P1 = P1 - P1 * 0.2;
                    }
                }
                Console.WriteLine("{0:f2}", P1 + 2);
            }
            else if (season == "Autumn" || season == "Winter")
            {
                if (praznik == "Y")
                {
                    P2 = P2 + P2 * 0.15;
                    if (rose >= 10)
                    {
                        P2 = P2 - P2 * 0.1;
                        if (hriz + rose + lale > 20) P2 = P2 - P2 * 0.2;
                    }
                }
                else if (praznik == "N")
                {
                    if (rose >= 10)
                    {
                        P2 = P2 - P2 * 0.1;
                        if (hriz + rose + lale > 20) P2 = P2 - P2 * 0.2;
                    }
                }
                      Console.WriteLine("{0:f2}", P2+2);

                }


            }
        }
    }

