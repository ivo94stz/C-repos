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
            var input = Console.ReadLine();
            input.Split(':');
            var name = input[0].ToString();
            var cards = input[1].ToString().Split(", ".ToCharArray(),StringSplitOptions.RemoveEmptyEntries).Select(cardvalue).ToArray();
            
            var hands = new Dictionary<string, List<int>>();

            Console.WriteLine();


            if (!hands.ContainsKey(name))
            {
                hands[name] = new List<int>();
            }
            hands[name].AddRange(cards);


            input = Console.ReadLine();

            foreach (var item in hands)
            {
                var newname = item.Key;
                var newcards = item.Value;
                Console.WriteLine();
            }
        }


        
         static int cardvalue(string card)
        {
            var cardpower = new Dictionary<string, int>();
            cardpower["J"] = 11;
            cardpower["Q"] = 12;
            cardpower["K"] = 13;
            cardpower["A"] = 14;

            for (int i = 2; i <= 10; i++)
            {
                cardpower[i.ToString()] = i;
            }

            var cardtype = new Dictionary<string, int>();
            cardtype["C"] = 1;
            cardtype["D"] = 2;
            cardtype["H"] = 3;
            cardtype["S"] = 4;

            var power = card.Substring(0,card.Length-1);
            var type = card.Substring(card.Length-1);
            var value = cardpower[power] * cardtype[type];

            
            return value;
        }
    }
}
