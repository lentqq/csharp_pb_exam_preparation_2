using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.SumOfTwoNumbers
{
    class SumOfTwoNumbers
    {
        static void Main(string[] args)
        {
            int start = int.Parse(Console.ReadLine());
            int end = int.Parse(Console.ReadLine());
            int magicNumber = int.Parse(Console.ReadLine());
            int count = 0;
            int sum = 0;
            bool combination = false;

            for (int i = start; i <= end; i++)
            {
                for (int j = start; j <= end; j++)
                {
                    count++;
                    sum = i + j;
                    if (sum == magicNumber)
                    {
                        combination = true;
                        Console.WriteLine($"Combination N:{count} ({i} + {j} = " +
                            $"{magicNumber})");
                        break;
                    }

                }
                if (sum == magicNumber)
                {
                    break;
                }
            }
            if (combination == false)
            {
                Console.WriteLine($"{count} combinations - neither equals {magicNumber}");
            }
        }
    }
}
