using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Ivanovi_sFamily
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            double firstKidGiftPrice = double.Parse(Console.ReadLine());
            double secondKidGiftPrice = double.Parse(Console.ReadLine());
            double thirdKidGiftPrice = double.Parse(Console.ReadLine());

            double totalSumGift = firstKidGiftPrice + secondKidGiftPrice + thirdKidGiftPrice;
            double netSum = budget - totalSumGift;
            double taks = netSum * 0.10;
            double charity = netSum - taks;

            Console.WriteLine($"{charity:f2}");
        }
    }
}
