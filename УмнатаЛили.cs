using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.УмнатаЛили
{
    class УмнатаЛили
    {
        static void Main(string[] args)
        {
            int age = int.Parse(Console.ReadLine());
            double laundryPrice = double.Parse(Console.ReadLine());
            int unitPriceToy = int.Parse(Console.ReadLine());
            int numToys = 0;
            int stolenMoney = 0;
            double totalSum = 0.0;
            double sum = 0.0;
            for (int i = 1; i <= age; i++)
            {
                if (i % 2 != 0)
                {
                    numToys++;
                }
                if (i % 2 == 0)
                {
                    sum += 10;
                    totalSum += sum;
                    stolenMoney++;
                }
            }
            int soldToys = numToys * unitPriceToy;
            double leftMoney = totalSum + soldToys - stolenMoney;

            if (leftMoney >= laundryPrice)
            {
                Console.WriteLine($"Yes! {leftMoney - laundryPrice:f2}");
            }
            else
            {
                Console.WriteLine($"No! {laundryPrice - leftMoney:f2}");
            }
        }
    }
}
