using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.SoftUniLogo
{
    class SoftUniLogo
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int width = 12 * n - 5;
            int heigth = 4 * n - 2;

            int dots = (width - 1) / 2;
            int sharps = 1;
            for (int i = 1; i <= 2 * n; i++)
            {
                Console.WriteLine("{0}{1}{0}", new string('.', dots),
                    new string('#', sharps));
                dots -= 3;
                sharps += 6;
            }
            int leftDots = 2;
            int rigthDots = 3;
            int sharp = width - leftDots - rigthDots - 1;
            for (int i = 0; i < n - 2; i++)
            {
                Console.WriteLine("|{0}{1}{2}", new string('.', leftDots),
                    new string('#', sharp),
                    new string('.', rigthDots));
                leftDots += 3;
                sharp -= 6;
                rigthDots += 3;
            }
            int downSharp = 6 * n + 1;
            int rdownDots = (width - downSharp) / 2;
            int ldownDots = width - rdownDots - downSharp - 1;

            for (int i = 2; i <= n; i++)
            {

                {
                    Console.WriteLine("|{0}{1}{2}", new string('.', ldownDots),
                        new string('#', downSharp),
                        new string('.', rdownDots));
                }

                if (i == n)
                {
                    Console.WriteLine("@{0}{1}{2}", new string('.', ldownDots),
                                       new string('#', downSharp),
                                       new string('.', rdownDots));
                }
            }
        }
    }
}
