using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.DogHouse
{
    class DogHouse
    {
        static void Main(string[] args)
        {
            double lengthSideWall = double.Parse(Console.ReadLine());
            double heigthHouse = double.Parse(Console.ReadLine());

            double sideWallArea = lengthSideWall * (lengthSideWall / 2) * 2;
            double backSideArea = Math.Pow(lengthSideWall / 2, 2) +
                (lengthSideWall / 2 * (heigthHouse - lengthSideWall / 2)) / 2;
            double entrance = Math.Pow(lengthSideWall / 5, 2);
            double frontSideArea = backSideArea - entrance;
            double roofArea = lengthSideWall * (lengthSideWall / 2) * 2;
            double totalAreaSide = sideWallArea + backSideArea + frontSideArea;

            double greenColor = totalAreaSide / 3.00;
            double redColor = roofArea / 5.00;

            Console.WriteLine($"{greenColor:f2}");
            Console.WriteLine($"{redColor:f2}");
        }
    }
}
