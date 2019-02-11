using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.ЗеленчуковаБорса
{
    class ЗеленчуковаБорса
    {
        static void Main(string[] args)
        {
            double vegetablesPrice = double.Parse(Console.ReadLine());
            double fruitsPrice = double.Parse(Console.ReadLine());
            int vegetablesQuantity = int.Parse(Console.ReadLine());
            int fruitsQuantity = int.Parse(Console.ReadLine());

            double euro = 1.94;
            double totalVegetablesPrice = vegetablesPrice * vegetablesQuantity;
            double totalFruitsPrice = fruitsPrice * fruitsQuantity;
            double totalSum = (totalFruitsPrice + totalVegetablesPrice) / euro;
            Console.WriteLine($"{totalSum}");
        }
    }
}
