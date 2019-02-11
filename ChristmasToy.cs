using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.ChristmasToy
{
    class ChristmasToy
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int width = 5 * n;
            int heigth = 2 * n + 3;

            Console.WriteLine($"{new string('-', (width - n) / 2)}" +
                $"{new string('*', n)}{new string('-', (width - n) / 2)}");

            int amper = n + 2;
            int star = 1;
            int dashes = (width - amper - 2 * star) / 2;
            for (int i = 1; i <= n / 2; i++)
            {
                Console.WriteLine($"{new string('-', dashes)}" +
                    $"{new string('*', star)}" +
                    $"{new string('&', amper)}" +
                    $"{new string('*', star)}" +
                    $"{new string('-', dashes)}");
                dashes -= 2;
                star += 1;
                amper += 2;
            }
            for (int i = 1; i <= n / 2; i++)
            {
                Console.WriteLine($"{new string('-', n - i)}**" +
                    $"{new string('~', width - 4 - (n - i) * 2)}**" +
                    $"{new string('-', n - i)}");
            }
            Console.WriteLine($"{new string('-', n / 2)}*" +
                $"{new string('|', width - 2 - (n / 2) * 2)}*" +
                $"{new string('-', n / 2)}");
            for (int i = n / 2; i >= 1; i--)
            {
                Console.WriteLine($"{new string('-', n - i)}**" +
                   $"{new string('~', width - 4 - (n - i) * 2)}**" +
                   $"{new string('-', n - i)}");
            }
            int dashe = n;
            int stars = n / 2;
            int ampers = 2 * n;
            for (int i = 1; i <= n / 2; i++)
            {
                Console.WriteLine($"{new string('-', dashe)}" +
                   $"{new string('*', stars)}" +
                   $"{new string('&', ampers)}" +
                   $"{new string('*', stars)}" +
                   $"{new string('-', dashe)}");
                dashe += 2;
                stars -= 1;
                ampers -= 2;
            }
            Console.WriteLine($"{new string('-', (width - n) / 2)}" +
                          $"{new string('*', n)}{new string('-', (width - n) / 2)}");
        }
    }
}
