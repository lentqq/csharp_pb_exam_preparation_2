using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Workout
{
    class Workout
    {
        static void Main(string[] args)
        {
            int numTrainingDays = int.Parse(Console.ReadLine());
            double firstDaysKm = double.Parse(Console.ReadLine());
            double totalDayKm = firstDaysKm;
            double totalKms = 0.00;
            for (int i = 1; i <= numTrainingDays; i++)
            {

                double percentDailyRate = double.Parse(Console.ReadLine());

                totalDayKm = totalDayKm + (percentDailyRate / 100) * totalDayKm;
                totalKms += totalDayKm;
            }
            totalKms = totalKms + firstDaysKm;

            if (totalKms >= 1000)
            {
                Console.WriteLine($"You've done a great job running {Math.Ceiling(totalKms - 1000)} more kilometers!");
            }
            else
            {
                Console.WriteLine($"Sorry Mrs. Ivanova, you need to run {Math.Ceiling(1000 - totalKms)} more kilometers");
            }
        }
    }
}
