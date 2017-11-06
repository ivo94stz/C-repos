using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace thea_the_photographer
{
    class Program
    {
        static void Main(string[] args)
        {
            double pics = double.Parse(Console.ReadLine());
            double secperpic = double.Parse(Console.ReadLine());
            double goodpics = double.Parse(Console.ReadLine());
            double secpergood = double.Parse(Console.ReadLine());

            double filteredpics = pics * (goodpics / 100);
            double filteredpics1 = Math.Ceiling(filteredpics);
            double totalsecs = pics * secperpic;
            double totalsecsfiltered = filteredpics1 * secpergood;
            double totaltime = totalsecs + totalsecsfiltered;

            

            TimeSpan time = TimeSpan.FromSeconds(totaltime);
            string timeresult = string.Format("{0:D1}:{1:D2}:{2:D2}:{3:D2}",
                time.Days,
                time.Hours,
                time.Minutes,
                time.Seconds);
            Console.WriteLine(timeresult);


            




        }
    }
}
