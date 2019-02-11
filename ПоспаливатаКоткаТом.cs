using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.ПоспаливатаКоткаТом
{
    class ПоспаливатаКоткаТом
    {
        static void Main(string[] args)
        {
            int numDayOff = int.Parse(Console.ReadLine());
            int playNorm = 30000;
            int workingPlayTime = 63;
            int dayOffPlayTime = 127;
            int numDaysInYear = 365;

            int workingDays = numDaysInYear - numDayOff;
            int totalWorkingPlayTime = workingDays * workingPlayTime;
            int totalDayOffPlayTime = numDayOff * dayOffPlayTime;
            int totalPlayTime = totalDayOffPlayTime + totalWorkingPlayTime;
            int difference = Math.Abs(playNorm - totalPlayTime);
            int hours = difference / 60;
            int minutes = difference - hours * 60;

            if (totalPlayTime > playNorm)
            {
                Console.WriteLine("Tom will run away");
                Console.WriteLine($"{hours} hours and {minutes} minutes more for play");
            }
            else if (totalPlayTime <= playNorm)
            {
                Console.WriteLine("Tom sleeps well");
                Console.WriteLine($"{hours} hours and {minutes} minutes less for play");
            }
        }
    }
}
