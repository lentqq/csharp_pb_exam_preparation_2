using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.ChristmasSock
{
    class ChristmasSock
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int heigtht = 3 * n + 3;
            int upWidth = 2 * n + 2;
            for (int i = 1; i < 3; i++)
            {
                if (i == 2)
                    Console.WriteLine($"|{new string('*', 2 * n)}|");
                Console.WriteLine($"|{new string('-', 2 * n)}|");
            }
            for (int i = 1; i <= n - 1; i++)
            {
                Console.WriteLine($"|{new string('-', n - i)}" +
                    $"{new string('~', upWidth - 2 * (n - i) - 2)}" +
                    $"{new string('-', n - i)}|");
            }
            int dashes = 2;
            for (int i = 1; i <= n - 2; i++)
            {
                Console.WriteLine($"|{new string('-', dashes)}" +
                    $"{new string('~', upWidth - 2 * dashes - 2)}" +
                    $"{new string('-', dashes)}|");
                dashes++;
            }
            //DOWN PART

            string merry = "MERRY";
            string xmass = "X-MAS";
            int mery = 5;
            int xmas = 5;
            int downWidth = upWidth + 1;
            for (int i = 0; i < n + 2; i++)
            {
                Console.Write($"{new string('-', i)}");
                Console.Write("\\");
                if (i == n / 2)
                {
                    Console.Write($"{new string('.', n - 2)}{merry}{new string('.', n - 2)}");
                }
                else if (i == n / 2 + 2)
                {
                    Console.Write($"{new string('.', n - 2)}{xmass}{new string('.', n - 2)}");
                }
                else
                {
                    Console.Write($"{new string('.', downWidth - 2)}");
                }
                Console.WriteLine("\\");

            }
            Console.WriteLine($"{new string('-', n + 2)}\\{new string('_', downWidth - 2)})");
        }
    }
}
