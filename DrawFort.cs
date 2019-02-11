using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.DrawFort
{
    class DrawFort
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int width = 2 * n;
            int height = n;
            int widthInsideColums = n / 2;

            Console.WriteLine($"/{new string('^', widthInsideColums)}\\" +
                $"{new string('_', width - 4 - 2 * widthInsideColums)}/" +
                $"{new string('^', widthInsideColums)}\\");
            if (n == 3)
            {
                for (int j = 0; j < height - 2; j++)
                {
                    Console.WriteLine($"|{new string(' ', width - 2)}|");
                }
            }
            else
            {
                for (int i = 2; i <= height - 2; i++)
                {

                    Console.WriteLine($"|{new string(' ', width - 2)}|");
                    if (i == height - 2)
                    {
                        Console.WriteLine($"|{new string(' ', widthInsideColums)} " +
                            $"{new string('_', width - 4 - 2 * widthInsideColums)} " +
                            $"{new string(' ', widthInsideColums)}|");
                    }
                }
            }
            Console.WriteLine($"\\{new string('_', widthInsideColums)}/" +
                $"{new string(' ', width - 4 - 2 * widthInsideColums)}\\" +
                $"{new string('_', widthInsideColums)}/");
        }
    }
}
