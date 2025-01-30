using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int test = ReverseValue(234);
            Console.WriteLine(test);
        }

        static int ReverseValue(int value)
        {
            int revCount = 100;
            int revValue = 0;

            for (int i = 0; i < 3; i++)
            {
                revValue += ((value % 10) * revCount);
                revCount /= 10;
                value /= 10;
            }
            return revValue;
        }
    }
}
