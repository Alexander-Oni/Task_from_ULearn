using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int firstYear = 1996;
            int secondYear = 2024;

            Console.WriteLine(LeapYearCounting(firstYear, secondYear));
            Console.WriteLine(LeapYearCountingWithFor(firstYear, secondYear));
        }

        static int LeapYearCounting(int firstYear, int secondYear)
        {
            return (secondYear - firstYear) / 4 + 1;
        }

        static int LeapYearCountingWithFor(int firstYear, int secondYear)
        {
            int count = 0;
            for (int i = firstYear; i <= secondYear; i++)
            {
                if (i % 4 == 0)
                    count++;
            }
            return count;
        }
    }
}
