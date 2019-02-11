using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.FinalCompetition
{
    class FinalCompetition
    {
        static void Main(string[] args)
        {
            int dancers = int.Parse(Console.ReadLine());
            double points = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            string places = Console.ReadLine().ToLower();

            double money = 0.00;
            double moneyAfterCosts = 0.00;
            double charity = 0.00;
            double leftMoney = 0.00;
            double moneyPerDancer = 0.00;

            switch (season)
            {
                case "summer":
                    if (places == "bulgaria")
                    {
                        money = dancers * points;
                        moneyAfterCosts = money - (money * 0.05);
                        charity = moneyAfterCosts * 0.75;
                        leftMoney = moneyAfterCosts - charity;
                        moneyPerDancer = leftMoney / dancers;
                    }
                    else if (places == "abroad")
                    {
                        money = dancers * points + (dancers * points * 0.50);
                        moneyAfterCosts = money - (money * 0.10);
                        charity = moneyAfterCosts * 0.75;
                        leftMoney = moneyAfterCosts - charity;
                        moneyPerDancer = leftMoney / dancers;
                    }
                    break;
                case "winter":
                    if (places == "bulgaria")
                    {
                        money = dancers * points;
                        moneyAfterCosts = money - (money * 0.08);
                        charity = moneyAfterCosts * 0.75;
                        leftMoney = moneyAfterCosts - charity;
                        moneyPerDancer = leftMoney / dancers;
                    }
                    else if (places == "abroad")
                    {
                        money = dancers * points + (dancers * points * 0.50);
                        moneyAfterCosts = money - (money * 0.15);
                        charity = moneyAfterCosts * 0.75;
                        leftMoney = moneyAfterCosts - charity;
                        moneyPerDancer = leftMoney / dancers;
                    }
                    break;
            }
            Console.WriteLine($"Charity - {charity:f2}");
            Console.WriteLine($"Money per dancer - {moneyPerDancer:f2}");
        }
    }
}
