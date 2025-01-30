using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(FindNumberWithSimpDiv("1000 3 7"));
        }

        static int FindNumberWithSimpDiv(string userInput)
        {
            int[] values = userInput.Split(' ').Select(int.Parse).ToArray(); 

            int userNumber = values[0];
            int firstSimpDiv = values[1];
            int secondSimpDiv = values[2];
            int numWithSimpDiv = 0;

            for (int i = userNumber; i > 0; i--)
            {
                if (i % firstSimpDiv == 0 && i % secondSimpDiv == 0)
                    numWithSimpDiv++;
            }
            return numWithSimpDiv;
        }
    }
}
