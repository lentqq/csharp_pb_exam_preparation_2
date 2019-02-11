using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.CarToGo
{
    class CarToGo
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine().ToLower();

            if (budget <= 100)
            {
                Console.WriteLine("Economy class");
                if (season == "summer")
                {
                    Console.WriteLine($"Cabrio - {0.35 * budget:f2}");
                }
                else if (season == "winter")
                {
                    Console.WriteLine($"Jeep - {0.65 * budget:f2}");
                }
            }
            else if (budget > 100 && budget <= 500)
            {
                Console.WriteLine("Compact class");
                if (season == "summer")
                {
                    Console.WriteLine($"Cabrio - {0.45 * budget:f2}");
                }
                else if (season == "winter")
                {
                    Console.WriteLine($"Jeep - {0.80 * budget:f2}");
                }
            }
            else if (budget > 500)
            {
                Console.WriteLine("Luxury class");
                Console.WriteLine($"Jeep - {0.90 * budget:f2}");
            }
        }
    }
}
