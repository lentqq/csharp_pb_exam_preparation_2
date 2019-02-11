using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.DeerOfSanta
{
    class DeerOfSanta
    {
        static void Main(string[] args)
        {
            int missingNumDays = int.Parse(Console.ReadLine());
            int leftFood = int.Parse(Console.ReadLine());
            double firstDeerFood = double.Parse(Console.ReadLine());
            double secondDeerFood = double.Parse(Console.ReadLine());
            double thirdDeerFood = double.Parse(Console.ReadLine());
            double firstDeerNeedFood = missingNumDays * firstDeerFood;
            double secondDeerNeedFood = missingNumDays * secondDeerFood;
            double thirdDeerNeedFood = missingNumDays * thirdDeerFood;
            double totalNeedFood = firstDeerNeedFood + secondDeerNeedFood + thirdDeerNeedFood;
            if (totalNeedFood <= leftFood)
            {
                Console.WriteLine($"{Math.Floor(leftFood - totalNeedFood)} kilos of food left.");
            }
            else
            {
                Console.WriteLine($"{Math.Ceiling(totalNeedFood - leftFood)} more kilos of food are needed.");
            }
        }
    }
}
