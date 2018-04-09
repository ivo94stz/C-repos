using System;

namespace Telephony
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] numbers = Console.ReadLine().Split();
            string[] urls = Console.ReadLine().Split();

            for (int i = 0; i < numbers.Length; i++)
            {
                string number = numbers[i];
                var phone = new Smartphone();
                Console.WriteLine(phone.Call(number));
            }

            for (int i = 0; i < urls.Length; i++)
            {
                string url = urls[i];
                var phone = new Smartphone();
                Console.WriteLine(phone.Web(url));
            }

        }
    }
}
