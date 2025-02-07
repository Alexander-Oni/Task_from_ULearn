namespace Exercise6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] test = new int[,] { { 1, 2 }, { 3, 4 }, { 5, 6 } };
            Console.WriteLine(DistanceToLine(test));

            int[,] test1 = new int[,] { { 1, 2 }, { 3, 4 }, { 6, 8 } };
            Console.WriteLine(DistanceToLine(test1));

            int[,] test2 = new int[,] { { 10, 0 }, { 0, 0 }, { 8, 6 } };
            Console.WriteLine(DistanceToLine(test2));

            int[,] test3 = new int[,] { { 8, 0 }, { 0, 0 }, { 6, 2 } };
            Console.WriteLine(DistanceToLine(test3));
        }
        static double DistanceToLine(int[,] coordinates)
        {
            double x0 = coordinates[0,0];  //   
            double y0 = coordinates[0,1];  //   координаты точки
            double x1 = coordinates[1,0];  //
            double y1 = coordinates[1,1];  //   координаты точки на прямой
            double x2 = coordinates[2,0];  //
            double y2 = coordinates[2,1];  //   координаты точки на прямой

            double A = y2 - y1;
            double B = x2 - x1;
            double C = A * -x1 + B * y1;

            double distance = (Math.Abs(A * x0 - B * y0 + C)) / Math.Sqrt(A * A + B * B);

            return distance;
        }
    }
}
