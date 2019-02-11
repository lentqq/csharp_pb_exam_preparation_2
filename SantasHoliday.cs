using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.SantasHoliday
{
    class SantasHoliday
    {
        static void Main(string[] args)
        {
            int stayDays = int.Parse(Console.ReadLine());
            string kindOfRoom = Console.ReadLine();
            string evaluation = Console.ReadLine();
            double price = 1.00;
            double priceWithDiscount = 1.00;
            double totalPrice = 1.00;
            switch (kindOfRoom)
            {
                case "room for one person":
                    price = (stayDays - 1) * 18.00;
                    priceWithDiscount = price;
                    break;
                case "apartment":
                    price = (stayDays - 1) * 25.00;
                    if (stayDays < 10)
                    {
                        priceWithDiscount = price - price * 0.30;
                    }
                    else if (stayDays >= 10 && stayDays <= 15)
                    {
                        priceWithDiscount = price - price * 0.35;
                    }
                    else if (stayDays > 15)
                    {
                        priceWithDiscount = price - price * 0.50;
                    }
                    break;
                case "president apartment":
                    price = (stayDays - 1) * 35.00;
                    if (stayDays < 10)
                    {
                        priceWithDiscount = price - price * 0.10;
                    }
                    else if (stayDays >= 10 && stayDays <= 15)
                    {
                        priceWithDiscount = price - price * 0.15;
                    }
                    else if (stayDays > 15)
                    {
                        priceWithDiscount = price - price * 0.20;
                    }
                    break;
            }
            if (evaluation == "positive")
            {
                totalPrice = priceWithDiscount + priceWithDiscount * 0.25;
            }
            else if (evaluation == "negative")
            {
                totalPrice = priceWithDiscount - priceWithDiscount * 0.10;
            }
            Console.WriteLine($"{totalPrice:f2}");
        }
    }
}
