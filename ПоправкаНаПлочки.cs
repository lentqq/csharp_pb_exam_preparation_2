using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.ПоправкаНаПлочки
{
    class ПоправкаНаПлочки
    {
        static void Main(string[] args)
        {
            double squareLength = double.Parse(Console.ReadLine());
            double tileWidth = double.Parse(Console.ReadLine());
            double tileLength = double.Parse(Console.ReadLine());
            double benchWidth = double.Parse(Console.ReadLine());
            double benchLength = double.Parse(Console.ReadLine());
            double timePlacement = 0.2;
            double squareArea = Math.Pow(squareLength, 2);
            double benchArea = benchWidth * benchLength;
            double placementArea = squareArea - benchArea;
            double tileArea = tileLength * tileWidth;
            double neededTiles = placementArea / tileArea;
            double neededTime = neededTiles * timePlacement;
            Console.WriteLine($"{neededTiles:f2}");
            Console.WriteLine($"{neededTime:f2}");
        }
    }
}
