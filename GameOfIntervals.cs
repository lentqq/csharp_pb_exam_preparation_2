using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.GameOfIntervals
{
    class GameOfIntervals
    {
        static void Main(string[] args)
        {
            int moves = int.Parse(Console.ReadLine());
            double result = 0.00;
            double count1 = 0;
            double count2 = 0;
            double count3 = 0;
            double count4 = 0;
            double count5 = 0;
            double count6 = 0;

            for (int i = 1; i <= moves; i++)
            {
                int eachmoves = int.Parse(Console.ReadLine());
                if (eachmoves >= 0 && eachmoves < 10)
                {
                    result += 0.20 * eachmoves;
                    count1++;
                }
                else if (eachmoves >= 10 && eachmoves < 20)
                {
                    result += 0.30 * eachmoves;
                    count2++;
                }
                else if (eachmoves >= 20 && eachmoves < 30)
                {
                    result += 0.40 * eachmoves;
                    count3++;
                }

                else if (eachmoves >= 30 && eachmoves < 40)
                {
                    result += 50.00;
                    count4++;
                }
                else if (eachmoves >= 40 && eachmoves <= 50)
                {
                    result += 100.00;
                    count5++;
                }
                else if (eachmoves < 0 || eachmoves > 50)
                {
                    result = result / 2.00;
                    count6++;
                }
            }
            Console.WriteLine($"{result:f2}");
            Console.WriteLine($"From 0 to 9: {count1 / moves * 100:f2}%");
            Console.WriteLine($"From 10 to 19: {count2 / moves * 100:f2}%");
            Console.WriteLine($"From 20 to 29: {count3 / moves * 100:f2}%");
            Console.WriteLine($"From 30 to 39: {count4 / moves * 100:f2}%");
            Console.WriteLine($"From 40 to 50: {count5 / moves * 100:f2}%");
            Console.WriteLine($"Invalid numbers: {count6 / moves * 100:f2}%");
            //Console.WriteLine($"From 0 to 9: {count1 / moves:P}");
            //Console.WriteLine($"From 10 to 19: {count2 / moves:P}");
            //Console.WriteLine($"From 20 to 29: {count3 / moves:P}");
            //Console.WriteLine($"From  30 to 39: {count4 / moves:P}");
            //Console.WriteLine($"From 40 to 50: {count5 / moves:P}");
            //Console.WriteLine($"Invalid numbers: {count6 / moves:P}");
        }
    }
}
