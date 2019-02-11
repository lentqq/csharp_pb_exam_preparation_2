using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.TransportPrice
{
    class TransportPrice
    {
        static void Main(string[] args)
        {
            int km = int.Parse(Console.ReadLine());
            string time = Console.ReadLine();

            double startingFeeTaxi = 0.70;
            double taxiDaylyRate = 0.0;
            double taxiNightRate = 0.0;
            double busRate = 0.0;
            double trainRate = 0.0;
            double distanceWithTaxi = 0.0;
            double distanceWithBus = 0.0;
            double distanceWithTrain = 0.0;
            switch (time)
            {
                case "day":
                    taxiDaylyRate = 0.79;
                    distanceWithTaxi = km * taxiDaylyRate + startingFeeTaxi;
                    busRate = 0.09;
                    distanceWithBus = km * busRate;
                    trainRate = 0.06;
                    distanceWithTrain = km * trainRate;
                    break;
                case "night":
                    taxiNightRate = 0.90;
                    distanceWithTaxi = km * taxiNightRate + startingFeeTaxi;
                    busRate = 0.09;
                    distanceWithBus = km * busRate;
                    trainRate = 0.06;
                    distanceWithTrain = km * trainRate;
                    break;
            }
            if (km < 20 && time == "day")
            {
                Console.WriteLine(distanceWithTaxi);
            }
            else if (km < 20 && time == "night")
            {
                Console.WriteLine(distanceWithTaxi);
            }
            else if (km >= 20 && km < 100)
            {
                Console.WriteLine(Math.Min(distanceWithBus, distanceWithTaxi));
            }
            else if (km >= 100)
            {
                Console.WriteLine(distanceWithTrain);
            }
        }
    }
}
