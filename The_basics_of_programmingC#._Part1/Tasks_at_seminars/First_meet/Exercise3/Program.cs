using System;


namespace Exercise3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 25; i++) 
                Console.WriteLine(AngleBetweenHoursAndMinutes(i));
            }

        static int AngleBetweenHoursAndMinutes(int hours)
        {
            int hAng = 30 * (hours % 12); // сбрасываем до 12 часовошо формата

            return hAng > 180 ? 360 - hAng : hAng; // проверка стороны часов
        }
    }
}
