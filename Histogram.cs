using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Histogram
{
    class Histogram
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double p1 = 0.0;
            double p2 = 0.0;
            double p3 = 0.0;
            double p4 = 0.0;
            double p5 = 0.0;

            for (int i = 1; i <= n; i++)
            {
                int num = int.Parse(Console.ReadLine());
                if (num < 200)
                {
                    p1++;
                }
                if (num >= 200 && num < 400)
                {
                    p2++;
                }
                if (num >= 400 && num < 600)
                {
                    p3++;
                }
                if (num >= 600 && num < 800)
                {
                    p4++;
                }
                if (num >= 800)
                {
                    p5++;
                }
            }
            Console.WriteLine($"{p1 / n * 100:f2}%");
            Console.WriteLine($"{p2 / n * 100:f2}%");
            Console.WriteLine($"{p3 / n * 100:f2}%");
            Console.WriteLine($"{p4 / n * 100:f2}%");
            Console.WriteLine($"{p5 / n * 100:f2}%");
        }
    }
}
