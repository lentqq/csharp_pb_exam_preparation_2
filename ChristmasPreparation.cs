using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.ChristmasPreparation
{
    class ChristmasPreparation
    {
        static void Main(string[] args)
        {
            int numRollsWrappingPaper = int.Parse(Console.ReadLine());
            int numRollsCloth = int.Parse(Console.ReadLine());
            double glue = double.Parse(Console.ReadLine());
            int percentDiscount = int.Parse(Console.ReadLine());
            double wrappingPaperPricePerRoll = 5.80;
            double clothPriceRoll = 7.20;
            double gluePriceLiter = 1.20;
            double wrappingPrice = numRollsWrappingPaper * wrappingPaperPricePerRoll;
            double clothPrice = numRollsCloth * clothPriceRoll;
            double gluePrice = glue * gluePriceLiter;
            double totalPriceMaterials = wrappingPrice + clothPrice + gluePrice;
            double priceWithDiscount = totalPriceMaterials - ((totalPriceMaterials * percentDiscount) / 100);
            Console.WriteLine($"{priceWithDiscount:f3}");
        }
    }
}
