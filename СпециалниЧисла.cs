using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.СпециалниЧисла
{
    class СпециалниЧисла
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= 9; i++)
            {
                for (int j = 1; j <= 9; j++)
                {
                    for (int l = 1; l <= 9; l++)
                    {
                        for (int m = 1; m <= 9; m++)
                        {
                            if (n % i == 0 && n % j == 0 && n % l == 0 && n % m == 0)
                            {
                                Console.Write($"{i}{j}{l}{m} ");
                            }
                        }
                    }
                }
            }
        }
    }
}
