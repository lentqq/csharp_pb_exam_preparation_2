using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Battles
{
    class Battles
    {
        static void Main(string[] args)
        {
            int pokemonFirstPlayer = int.Parse(Console.ReadLine());
            int pokemonSecondPlayer = int.Parse(Console.ReadLine());
            int maxBattles = int.Parse(Console.ReadLine());

            int counter = 0;
            for (int i = 1; i <= pokemonFirstPlayer; i++)
            {
                for (int j = 1; j <= pokemonSecondPlayer; j++)
                {
                    Console.Write($"({i} <-> {j}) ");
                    counter++;
                    if (counter == maxBattles)
                    {
                        return;
                    }
                }
            }
        }
    }
}
