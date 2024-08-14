using System;


namespace Exercise3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(AngleBetweenHoursAndMinutes(5));
        }

        static int AngleBetweenHoursAndMinutes(int hours)
        {
            return hours % 12 * 30;
        }
    }
}
