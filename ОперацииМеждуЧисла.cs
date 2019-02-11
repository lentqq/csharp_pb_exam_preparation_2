using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.ОперацииМеждуЧисла
{
    class ОперацииМеждуЧисла
    {
        static void Main(string[] args)
        {
            double n1 = int.Parse(Console.ReadLine());
            double n2 = int.Parse(Console.ReadLine());
            string symbol = Console.ReadLine();

            if (n2 == 0 && symbol == "/" || n2 == 0 && symbol == "%")
            {
                Console.WriteLine($"Cannot divide {n1} by zero");
            }

            if (symbol == "+")
            {
                double result = n1 + n2;
                if (result % 2 == 0)
                {
                    Console.WriteLine($"{n1} {symbol} {n2} = {result} - even");
                }
                else
                {
                    Console.WriteLine($"{n1} {symbol} {n2} = {result} - odd");
                }
            }
            else if (symbol == "-")
            {
                double result = n1 - n2;
                if (result % 2 == 0)
                {
                    Console.WriteLine($"{n1} {symbol} {n2} = {result} - even");
                }
                else
                {
                    Console.WriteLine($"{n1} {symbol} {n2} = {result} - odd");
                }
            }
            else if (symbol == "*")
            {
                double result = n1 * n2;
                if (result % 2 == 0)
                {
                    Console.WriteLine($"{n1} {symbol} {n2} = {result} - even");
                }
                else
                {
                    Console.WriteLine($"{n1} {symbol} {n2} = {result} - odd");
                }
            }
            else if (symbol == "/" && n2 != 0)
            {
                double result = n1 / n2;
                Console.WriteLine($"{n1} / {n2} = {result:f2}");
            }
            else if (symbol == "%" && n2 != 0)
            {
                double result = n1 % n2;
                Console.WriteLine($"{n1} % {n2} = {result}");
            }
        }
    }
}
