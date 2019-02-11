using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.DwarfPresents
{
    class DwarfPresents
    {
        static void Main(string[] args)
        {
            int numDwarf = int.Parse(Console.ReadLine());
            int budget = int.Parse(Console.ReadLine());
            double totalPrice = 0.00;

            for (int i = 1; i <= numDwarf; i++)
            {
                string gift = Console.ReadLine();
                if (gift == "sand clock")
                {
                    totalPrice += 2.20;
                }
                else if (gift == "magnet")
                {
                    totalPrice += 1.50;
                }
                else if (gift == "cup")
                {
                    totalPrice += 5.00;
                }
                else if (gift == "t-shirt")
                {
                    totalPrice += 10.00;
                }
            }
            if (totalPrice <= budget)
            {
                Console.WriteLine($"Santa Claus has {budget - totalPrice:f2} more leva left!");
            }
            else
            {
                Console.WriteLine($"Santa Claus will need {totalPrice - budget:f2} more leva.");

            }
        }
    }
}
