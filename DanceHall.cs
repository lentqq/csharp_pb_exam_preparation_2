using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.DanceHall
{
    class DanceHall
    {
        static void Main(string[] args)
        {
            double length = double.Parse(Console.ReadLine());
            double width = double.Parse(Console.ReadLine());
            double sideWardrobe = double.Parse(Console.ReadLine());
            double areaHall = (length * 100) * (width * 100);
            double wardrobeArea = (sideWardrobe * 100) * (sideWardrobe * 100);
            double benchArea = areaHall / 10;
            double freeSpaces = areaHall - wardrobeArea - benchArea;
            double numDancers = freeSpaces / (40 + 7000);
            Console.WriteLine($"{Math.Floor(numDancers)}");
        }
    }
}
