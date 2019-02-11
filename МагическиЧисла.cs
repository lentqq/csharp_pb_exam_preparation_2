using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.МагическиЧисла
{
    class МагическиЧисла
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
          
            for (int i = 1; i <= 9; i++)
            {
                for (int j = 1; j <= 9; j++)
                {
                    for (int k = 1; k <= 9; k++)
                    {
                        for (int m = 1; m <= 9; m++)
                        {
                            for (int l = 1; l <= 9; l++)
                            {
                                for (int s = 1; s <= 9; s++)
                                {
                                   
                                    if (i * j * k * m * l * s == n)
                                    {
                                        Console.Write($"{i}{j}{k}{m}{l}{s} ");
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}
