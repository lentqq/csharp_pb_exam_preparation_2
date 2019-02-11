using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.MultiplyTable
{
    class MultiplyTable
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int multiply = 1;
            for (int i = 1; i <= n % 10; i++)
            {
                for (int j = 1; j <= n / 10 % 10; j++)
                {
                    for (int h = 1; h <= n / 100; h++)
                    {
                        multiply = i * j * h;
                        Console.WriteLine($"{i} * {j} * {h} = {multiply};");
                    }
                }
            }
        }
    }
}
