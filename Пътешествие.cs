using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Пътешествие
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();

            double spentMoney = 0.00;

            if (budget <= 100)
            {
                if (season == "summer")
                {
                    spentMoney = budget * 0.30;
                    Console.WriteLine($"Somewhere in Bulgaria");
                    Console.WriteLine($"Camp - {spentMoney:f2}");
                }
                else if (season == "winter")
                {
                    spentMoney = budget * 0.70;
                    Console.WriteLine($"Somewhere in Bulgaria");
                    Console.WriteLine($"Hotel - {spentMoney:f2}");
                }
            }
            else if (budget > 100 && budget <= 1000)
            {
                if (season == "summer")
                {
                    spentMoney = budget * 0.40;
                    Console.WriteLine($"Somewhere in Balkans");
                    Console.WriteLine($"Camp - {spentMoney:f2}");
                }
                else if (season == "winter")
                {
                    spentMoney = budget * 0.80;
                    Console.WriteLine($"Somewhere in Balkans");
                    Console.WriteLine($"Hotel - {spentMoney:f2}");
                }
            }
            else if (budget > 1000)
            {
                spentMoney = budget * 0.90;
                Console.WriteLine($"Somewhere in Europe");
                Console.WriteLine($"Hotel - {spentMoney:f2}");
            }
        }
    }
}
