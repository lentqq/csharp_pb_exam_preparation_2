using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Pets
{
    class Pets
    {
        static void Main(string[] args)
        {
            int numDays = int.Parse(Console.ReadLine());
            int leftFoodKgs = int.Parse(Console.ReadLine());
            double dogFoodPerDayKgs = double.Parse(Console.ReadLine());
            double catFoodPerDaysKgs = double.Parse(Console.ReadLine());
            double turtleFoodDaysGrs = double.Parse(Console.ReadLine());

            double dogNeedFood = numDays * dogFoodPerDayKgs;
            double catNeedFood = numDays * catFoodPerDaysKgs;
            double turtleNeedFood = numDays * (turtleFoodDaysGrs / 1000.00);
            double tottalFood = dogNeedFood + catNeedFood + turtleNeedFood;

            if (tottalFood <= leftFoodKgs)
            {
                Console.WriteLine($"{Math.Floor(leftFoodKgs - tottalFood)} kilos of food left.");
            }
            else
            {
                Console.WriteLine($"{Math.Ceiling(tottalFood - leftFoodKgs)} more kilos of food are needed.");
            }
        }
    }
}
