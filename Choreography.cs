using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Choreography
{
    class Choreography
    {
        static void Main(string[] args)
        {
            int numSteps = int.Parse(Console.ReadLine());
            int numDancers = int.Parse(Console.ReadLine());
            int teachDays = int.Parse(Console.ReadLine());

            double stepsForDays = Math.Ceiling(((numSteps / teachDays) / (double)numSteps) * 100.00);
            double percentSteps = stepsForDays / numDancers;
            double totalPercent = numDancers * percentSteps;

            if (totalPercent <= 13)
            {
                Console.WriteLine($"Yes, they will succeed in that goal! {percentSteps:f2}%.");
            }
            else
            {
                Console.WriteLine($"No, They will not succeed in that goal! Required {percentSteps:f2}% steps to be learned per day.");
            }
        }
    }
}
