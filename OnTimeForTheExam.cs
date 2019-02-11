using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.OnTimeForTheExam
{
    class OnTimeForTheExam
    {
        static void Main(string[] args)
        {
            int startExamHour = int.Parse(Console.ReadLine());
            int startExamMinute = int.Parse(Console.ReadLine());
            int arrivalHour = int.Parse(Console.ReadLine());
            int arrivalMinute = int.Parse(Console.ReadLine());

            int totalExamMinutes = startExamHour * 60 + startExamMinute;
            int totalArrivalMinutes = arrivalHour * 60 + arrivalMinute;
            int difference = Math.Abs(totalExamMinutes - totalArrivalMinutes);
            int hour = difference / 60;
            int minutes = difference - hour * 60;

            if (totalArrivalMinutes > totalExamMinutes)
            {
                Console.WriteLine("Late");
                if (difference <= 59)
                {
                    Console.WriteLine($"{difference} minutes after the start");
                }
                else if (difference > 59)
                {
                    Console.WriteLine($"{hour}:{minutes} hours after the start");
                }
            }
            if (totalArrivalMinutes == totalExamMinutes)
            {
                Console.WriteLine("On time");
            }
            if (totalArrivalMinutes < totalExamMinutes && difference <= 30)
            {
                Console.WriteLine("On time");
                Console.WriteLine($"{difference} minutes before the start");
            }
            if (totalArrivalMinutes < totalExamMinutes && difference > 30)
            {
                Console.WriteLine("Early");
                if (difference > 30 && difference <= 59)
                {
                    Console.WriteLine($"{difference} minutes before the start");
                }
                else if (difference > 59)
                {                     
                        Console.WriteLine($"{hour}:{minutes:00} hours before the start");      
                }
            }
        }
    }
}
