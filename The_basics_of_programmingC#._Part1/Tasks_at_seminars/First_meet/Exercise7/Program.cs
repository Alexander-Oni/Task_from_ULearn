namespace Exercise7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] test = { 1, 2, 3 };
            PrintCoordinates(FindTheGuiding(test));
            PrintCoordinates(FindTheNormal(test));
            Console.WriteLine();
            Console.WriteLine();

            int[] test1 = { 4, -7, 8 };
            PrintCoordinates(FindTheGuiding(test1));
            PrintCoordinates(FindTheNormal(test1));
            Console.WriteLine();
            Console.WriteLine();

            int[] test2 = { 5, -5, 3 };
            PrintCoordinates(FindTheGuiding(test2));
            PrintCoordinates(FindTheNormal(test2));
            Console.WriteLine(); 
            Console.WriteLine();
        }

        static int[] FindTheGuiding(int[] coefficients)
        {
            int x = coefficients[1];
            int y = -coefficients[0];

            int[] result = { x, y };
            return result;
        }

        static int[] FindTheNormal(int[] coefficients)
        {
            int x = coefficients[0];
            int y = coefficients[1];

            int[] result = { x, y };
            return result;
        }

        static void PrintCoordinates(int[] coordinates)
        {
            Console.WriteLine("X: " + coordinates[0] + " Y: " + coordinates[1]);
        }
    }
}
