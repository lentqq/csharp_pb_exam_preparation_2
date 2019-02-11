using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.WorkHours
{
    class WorkHours
    {
        static void Main(string[] args)
        {
            int needHours = int.Parse(Console.ReadLine());
            int numWorkers = int.Parse(Console.ReadLine());
            int workDays = int.Parse(Console.ReadLine());

            int workHours = numWorkers * workDays * 8;

            if (workHours > needHours)
            {
                Console.WriteLine($"{workHours - needHours} hours left");
            }
            else
            {
                Console.WriteLine($"{needHours - workHours} overtime");
                int penalties = (needHours - workHours) * workDays;
                Console.WriteLine($"Penalties: {penalties}");
            }
        }
    }
}
