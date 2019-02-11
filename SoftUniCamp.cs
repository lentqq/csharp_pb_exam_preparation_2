using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.SoftUniCamp
{
    class SoftUniCamp
    {
        static void Main(string[] args)
        {
            int numGroupStudents = int.Parse(Console.ReadLine());
            double allTravelingPeople = 0.0;

            double carTraveling = 0.0;
            double microBusTraveling = 0.0;
            double miniBusTraveling = 0.0;
            double autoBusTraveling = 0.0;
            double trainTraveling = 0.0;

            for (int i = 0; i < numGroupStudents; i++)
            {
                int numPeopleInGroup = int.Parse(Console.ReadLine());
                allTravelingPeople += numPeopleInGroup;

                if (numPeopleInGroup <= 5)
                {
                    carTraveling += numPeopleInGroup;
                }
                if (numPeopleInGroup >= 6 && numPeopleInGroup <= 12)
                {
                    microBusTraveling += numPeopleInGroup;
                }
                if (numPeopleInGroup >= 13 && numPeopleInGroup <= 25)
                {
                    miniBusTraveling += numPeopleInGroup;
                }
                if (numPeopleInGroup >= 26 && numPeopleInGroup <= 40)
                {
                    autoBusTraveling += numPeopleInGroup;
                }
                if (numPeopleInGroup >= 41)
                {
                    trainTraveling += numPeopleInGroup;
                }


            }
            Console.WriteLine($"{carTraveling / allTravelingPeople * 100:f2}%");
            Console.WriteLine($"{microBusTraveling / allTravelingPeople * 100:f2}%");
            Console.WriteLine($"{miniBusTraveling / allTravelingPeople * 100:f2}%");
            Console.WriteLine($"{autoBusTraveling / allTravelingPeople * 100:f2}%");
            Console.WriteLine($"{trainTraveling / allTravelingPeople * 100:f2}%");
        }
    }
}
