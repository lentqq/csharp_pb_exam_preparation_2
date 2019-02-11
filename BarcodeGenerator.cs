using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.BarcodeGenerator
{
    class BarcodeGenerator
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());

            int nFirstDigit = n / 1000;
            int nSecondDigit = (n / 100) % 10;
            int nThirdDigit = (n / 10) % 10;
            int nFourthDigit = n % 10;

            int mFirstDigit = m / 1000;
            int mSecondDigit = (m / 100) % 10;
            int mThirdDigit = (m / 10) % 10;
            int mFourthDigit = m % 10;

            for (int i = nFirstDigit; i <= mFirstDigit; i++)
            {
                for (int j = nSecondDigit; j <= mSecondDigit; j++)
                {
                    for (int s = nThirdDigit; s <= mThirdDigit; i++)
                    {
                        for (int k = nFourthDigit; k <= mFourthDigit; k++)
                        {
                            if (i % 2 != 0 && j % 2 != 0 && s % 2 != 0 && k % 2 != 0)
                            {
                                Console.WriteLine($"{i}{j}{s}{k} ");
                            }
                        }
                    }
                }
            }
        }
    }
}
