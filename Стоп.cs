using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Стоп
{
    class Стоп
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int width = 4 * n + 3;

            Console.WriteLine($"{new string('.', n + 1)}" +
                $"{new string('_', width - 2 * (n + 1))}" +
                $"{new string('.', n + 1)}");

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"{new string('.', n - i)}//" +
                    $"{new string('_', width - 4 - 2 * (n - i))}\\\\" +
                    $"{new string('.', n - i)}");
            }

            Console.WriteLine($"//{new string('_', (width - 9) / 2)}STOP!" +
                $"{new string('_', (width - 9) / 2)}\\\\");

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"{new string('.', i)}\\\\" +
                    $"{new string('_', width - 4 -2 * i)}//" +
                    $"{new string('.', i)}");
            }
        }
    }
}
