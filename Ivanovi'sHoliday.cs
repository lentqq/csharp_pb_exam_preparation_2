using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Ivanovi_sHoliday
{
    class Program
    {
        static void Main(string[] args)
        {
            int numOvernight = int.Parse(Console.ReadLine());
            string destination = Console.ReadLine().ToLower();
            string transport = Console.ReadLine();

            double adultPriceOvernight = 1.00;
            double childPriceOvernight = 1.00;
            double adultPriceTransport = 1.00;
            double childPriceTransport = 1.00;

            switch (destination)
            {
                case "miami":
                    if (numOvernight >= 1 && numOvernight <= 10)
                    {
                        adultPriceOvernight = 24.99;
                        childPriceOvernight = 14.99;
                    }
                    else if (numOvernight >= 11 && numOvernight <= 15)
                    {
                        adultPriceOvernight = 22.99;
                        childPriceOvernight = 11.99;
                    }
                    else if (numOvernight > 15)
                    {
                        adultPriceOvernight = 20.00;
                        childPriceOvernight = 10.00;
                    }
                    break;
                case "canary islands":
                    if (numOvernight >= 1 && numOvernight <= 10)
                    {
                        adultPriceOvernight = 32.50;
                        childPriceOvernight = 28.50;
                    }
                    else if (numOvernight >= 11 && numOvernight <= 15)
                    {
                        adultPriceOvernight = 30.50;
                        childPriceOvernight = 25.60;
                    }
                    else if (numOvernight > 15)
                    {
                        adultPriceOvernight = 28.00;
                        childPriceOvernight = 22.00;
                    }
                    break;
                case "philippines":
                    if (numOvernight >= 1 && numOvernight <= 10)
                    {
                        adultPriceOvernight = 42.99;
                        childPriceOvernight = 39.99;
                    }
                    else if (numOvernight >= 11 && numOvernight <= 15)
                    {
                        adultPriceOvernight = 41.00;
                        childPriceOvernight = 36.00;
                    }
                    else if (numOvernight > 15)
                    {
                        adultPriceOvernight = 38.50;
                        childPriceOvernight = 32.40;
                    }
                    break;

            }
            double costsDestination = numOvernight * (adultPriceOvernight * 2 + childPriceOvernight * 3);
            double dogTaks = costsDestination * 0.25;
            double totalCostsDestination = costsDestination + dogTaks;

            switch (transport)
            {
                case "train":
                    adultPriceTransport = 22.30;
                    childPriceTransport = 12.50;
                    break;
                case "bus":
                    adultPriceTransport = 45.00;
                    childPriceTransport = 37.00;
                    break;
                case "airplane":
                    adultPriceTransport = 90.00;
                    childPriceTransport = 68.50;
                    break;
            }
            double coststransport = adultPriceTransport * 2 + childPriceTransport * 3;
            double totalCosts = totalCostsDestination + coststransport;

            Console.WriteLine($"{totalCosts:f3}");
        }
    }
}
