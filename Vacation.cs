using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Vacation
{
    class Vacation
    {
        static void Main(string[] args)
        {
            int adultsNum = int.Parse(Console.ReadLine());
            int studentsNum = int.Parse(Console.ReadLine());
            int numOvernigths = int.Parse(Console.ReadLine());
            string kindTransport = Console.ReadLine();

            double priceOvernigth = 82.99;
            double adultPriceTransport = 0.00;
            double studentspriceTransport = 0.00;

            switch (kindTransport)
            {
                case "train":
                    adultPriceTransport = 24.99;
                    studentspriceTransport = 14.99;

                    if (adultsNum + studentsNum >= 50)
                    {
                        adultPriceTransport = 24.99 - 24.99 * 0.50;
                        studentspriceTransport = 14.99 - 14.99 * 0.50;
                    }
                    break;
                case "bus":
                    adultPriceTransport = 32.50;
                    studentspriceTransport = 28.50;
                    break;
                case "boat":
                    adultPriceTransport = 42.99;
                    studentspriceTransport = 39.99;
                    break;
                case "airplane":
                    adultPriceTransport = 70.00;
                    studentspriceTransport = 50.00;
                    break;
            }
            double transportCosts = (adultsNum * adultPriceTransport + studentsNum * studentspriceTransport) * 2;
            double hotelCosts = numOvernigths * priceOvernigth;
            double commisions = (transportCosts + hotelCosts) * 0.10;
            double totalSum = transportCosts + hotelCosts + commisions;

            Console.WriteLine($"{totalSum:f2}");
        }
    }
}
