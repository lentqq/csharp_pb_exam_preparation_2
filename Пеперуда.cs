using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Пеперуда
{
    class Пеперуда
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int width = 2 * n - 1;
            int height = 2 * (n - 2) + 1;
            int side = n - 1;
            int simbols = n - 2;
            string stars = new string('*', simbols);
            string dashes = new string('-', simbols);

            // UP PART
            for (int i = 1; i <= n - 2; i++)
            {
                if (i % 2 != 0)
                {
                    Console.WriteLine($"{stars}\\ /{stars}");
                }
                if (i % 2 == 0)
                {
                    Console.WriteLine($"{dashes}\\ /{dashes}");
                }
            }
            // MIDDLE PART
            Console.WriteLine($"{new string(' ', side)}@{new string(' ', side)}");
            // DOWN PART

            for (int i = 1; i <= n - 2; i++)
            {
                if (i % 2 != 0)
                {
                    Console.WriteLine($"{stars}/ \\{stars}");
                }
                if (i % 2 == 0)
                {
                    Console.WriteLine($"{dashes}/ \\{dashes}");
                }
            }
        }
    }99;;;
}
