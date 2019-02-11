using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.NewYearsEveParty
{
    class Program
    {
        static void Main(string[] args)
        {
            int numGuests = int.Parse(Console.ReadLine());
            int budget = int.Parse(Console.ReadLine());
            int priceForPerson = 20;

            double priceCouvert = numGuests * priceForPerson;

            if (priceCouvert < budget)
            {
                double leftMoney = budget - priceCouvert;
                double fireworksMoney = leftMoney * 0.40;
                double donation = leftMoney - fireworksMoney;
                Console.WriteLine($"Yes! {Math.Truncate(fireworksMoney)} lv are for fireworks and {donation} lv are for donation.");
            }
            else
            {
                Console.WriteLine($"They won't have enough money to pay the covert. They will need {Math.Truncate(priceCouvert - budget)} lv more.");
            }
        }
    }
}
