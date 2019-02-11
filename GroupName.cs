using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.GroupName
{
    class GroupName
    {
        static void Main(string[] args)
        {
            char bigLetter = char.Parse(Console.ReadLine());
            char firstSmallLetter = char.Parse(Console.ReadLine());
            char secondSmallLetter = char.Parse(Console.ReadLine());
            char thirdSmallLetter = char.Parse(Console.ReadLine());
            int digit = int.Parse(Console.ReadLine());

            int counter = 0;
            for (char i = 'A'; i <= bigLetter; i++)
            {
                for (char k = 'a'; k <= firstSmallLetter; k++)
                {
                    for (char m = 'a'; m <= secondSmallLetter; m++)
                    {
                        for (char n = 'a'; n <= thirdSmallLetter; n++)
                        {
                            for (int l = 0; l <= digit; l++)
                            {
                                counter++;
                            }
                        }
                    }
                }
            }
            Console.WriteLine($"{counter - 1}");
        }
    }
}
