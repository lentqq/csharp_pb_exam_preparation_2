using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Fishland
{
    class Fishland
    {
        static void Main(string[] args)
        {
            double mackerelPriceKg = double.Parse(Console.ReadLine());
            double spratPriceKg = double.Parse(Console.ReadLine());
            double bonitoQantityKg = double.Parse(Console.ReadLine());
            double horsemackerelQuantityKg = double.Parse(Console.ReadLine());
            int musselsQantityKg = int.Parse(Console.ReadLine());
            double musselsPriceKg = 7.50;
            double bonitoPriceKg = mackerelPriceKg + mackerelPriceKg * 0.60;
            double horsemackerelPriceKg = spratPriceKg + spratPriceKg * 0.80;
            double bonitoSum = bonitoQantityKg * bonitoPriceKg;
            double horsemackerelSum = horsemackerelQuantityKg * horsemackerelPriceKg;
            double musselsSum = musselsQantityKg * musselsPriceKg;
            double totalSum = bonitoSum + horsemackerelSum + musselsSum;

            Console.WriteLine($"{totalSum:f2}");
        }
    }
}
