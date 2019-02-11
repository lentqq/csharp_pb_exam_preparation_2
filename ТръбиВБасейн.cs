using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.ТръбиВБасейн
{
    class ТръбиВБасейн
    {
        static void Main(string[] args)
        {
            int volumePool = int.Parse(Console.ReadLine());
            int fitstPipeDebitPerHour = int.Parse(Console.ReadLine());
            int secondPipeDebitPerHour = int.Parse(Console.ReadLine());
            double missingHours = double.Parse(Console.ReadLine());

            double firstPipeDebit = fitstPipeDebitPerHour * missingHours;
            double secondPipeDebit = secondPipeDebitPerHour * missingHours;
            double totalDebit = firstPipeDebit + secondPipeDebit;

            if (totalDebit <= volumePool)
            {
                Console.WriteLine($"The pool is {Math.Floor((totalDebit / volumePool) * 100)}% full." +
                    $" Pipe 1: {Math.Floor((firstPipeDebit / totalDebit) * 100)}%." +
                    $" Pipe 2: {Math.Floor((secondPipeDebit / totalDebit) * 100)}%.");
            }
            else
            {
                Console.WriteLine($"For {missingHours} hours the pool overflows with {totalDebit - volumePool:f1} liters.");
            }
        }
    }
}
