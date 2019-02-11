using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Fox
{
    class Fox
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int width = 2 * n + 3;
            // UP PART
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"{new string('*', i)}\\" +
                    $"{new string('-', width - 2 * i - 2)}" +
                    $"/{new string('*', i)}");
            }
            // MIDLLE PART
            int midlleStars = n;
            int sideStars = (width - midlleStars - 4) / 2;
            for (int i = 0; i < n / 3; i++)
            {
                Console.WriteLine($"|{new string('*', sideStars + i)}" +
                    $"\\{new string('*', midlleStars)}" +
                    $"/{new string('*', sideStars + i)}|");
                midlleStars -= 2;
            }
            // DOWN PART
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"{new string('-', i)}\\" +
                    $"{new string('*', width - 2 * i - 2)}" +
                    $"/{new string('-', i)}");
            }
        }
    }
}
