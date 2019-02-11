using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace _01.TrainingLab
{
    class TrainingLab
    {
        static void Main(string[] args)
        {
            double length = double.Parse(Console.ReadLine());
            double width = double.Parse(Console.ReadLine());

            int lostWorkingPlaces = 3;
            int coridorWidth = 100;
            int deskLength = 120;
            int deskWidth = 70;
            double numDesksOnRow = Math.Truncate((width * 100.0 - coridorWidth) / deskWidth);
            double numRows = Math.Truncate((length * 100.0) / deskLength);
            double numWorkingPlaces = numDesksOnRow * numRows - lostWorkingPlaces;

            Console.WriteLine($"{Math.Truncate(numWorkingPlaces)}");
        }
    }
}+
