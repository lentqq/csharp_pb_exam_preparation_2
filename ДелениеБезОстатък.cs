using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.ДелениеБезОстатък
{
    class ДелениеБезОстатък
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            double numbersDivision2 = 0.00;
            double numberDivision3 = 0.00;
            double numberDivision4 = 0.00;
            for (int i = 0; i < n; i++)
            {
                int numbers = int.Parse(Console.ReadLine());
                if (numbers % 2 == 0)
                {
                    numbersDivision2++;
                }
                if (numbers % 3 == 0)
                {
                    numberDivision3++;
                }
                if (numbers % 4 == 0)
                {
                    numberDivision4++;
                }
            }
            Console.WriteLine($"{(numbersDivision2 / n) * 100:f2}%");
            Console.WriteLine($"{(numberDivision3 / n) * 100:f2}%");
            Console.WriteLine($"{(numberDivision4 / n) * 100:f2}%");
        }
    }
}
