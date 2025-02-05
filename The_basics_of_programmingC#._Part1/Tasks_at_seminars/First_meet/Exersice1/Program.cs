using System;
using System.Linq;

namespace Exersice1
{
    internal class Program
    {
        static void Main(string[] args)
        {   
            int[] ints = new int[2];
            ints[0] = int.Parse(Console.ReadLine());
            ints[1] = int.Parse(Console.ReadLine());

            Console.WriteLine(ReplaceVariable(ints));
        }

        static string ReplaceVariable(int[] ints)
        {
            int[] revInt = { ints[1], ints[0] };
            return "Now first variable is " + revInt[0] + " and second variable is " + revInt[1];
        }
    }

}
