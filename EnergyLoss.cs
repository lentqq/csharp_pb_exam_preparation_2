using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.EnergyLoss
{
    class EnergyLoss
    {
        static void Main(string[] args)
        {
            int trainingDays = int.Parse(Console.ReadLine());
            int numDancers = int.Parse(Console.ReadLine());
            double devotedEnergy = 0.00;
            double totalDevotedEnergy = 0.00;
            double totalEnergy = 0.00;
            double leftEnergy = 0.00;
            double leftEnergyPerDancer = 0.00;
            for (int i = 1; i <= trainingDays; i++)
            {
                int trainingHours = int.Parse(Console.ReadLine());
                if (i % 2 == 0 && trainingHours % 2 == 0)
                {
                    devotedEnergy = numDancers * 68.00;
                }
                else if (i % 2 != 0 && trainingHours % 2 == 0)
                {
                    devotedEnergy = numDancers * 49.00;
                }
                else if (i % 2 == 0 && trainingHours % 2 != 0)
                {
                    devotedEnergy = numDancers * 65.00;
                }
                else if (i % 2 != 0 && trainingHours % 2 != 0)
                {
                    devotedEnergy = numDancers * 30.00;
                }
                totalDevotedEnergy += devotedEnergy;
            }
            totalEnergy = 100 * numDancers * trainingDays;
            leftEnergy = totalEnergy - totalDevotedEnergy;
            leftEnergyPerDancer = leftEnergy / numDancers / trainingDays;

            if (leftEnergyPerDancer > 50)
            {
                Console.WriteLine($"They feel good! Energy left: {leftEnergyPerDancer:f2}");
            }
            else if (leftEnergyPerDancer <= 50)
            {
                Console.WriteLine($"They are wasted! Energy left: {leftEnergyPerDancer:f2}");
            }
        }
    }
}
