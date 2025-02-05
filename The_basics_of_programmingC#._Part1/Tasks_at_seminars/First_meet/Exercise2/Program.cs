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
            int test1 = ReverseValue(123456789);
            Console.WriteLine(test1);

            int test2 = ReverseValue(12345678);
            Console.WriteLine(test2);

            int test3 = ReverseValue(1234567);
            Console.WriteLine(test3);

            int test4 = ReverseValue(123456);
            Console.WriteLine(test4);

            int test5 = ReverseValue(12345);
            Console.WriteLine(test5);
        }

        static int ReverseValue(int value)
        {
            int countOfNumber = value.ToString().Length;
            int revCount = (int)Math.Pow(10, (countOfNumber - 1));
            int revValue = 0;

            for (int i = 0; i < countOfNumber; i++)
            {
                revValue += ((value % 10) * revCount);
                revCount /= 10;
                value /= 10;
            }
            return revValue;
        }
    }
}
