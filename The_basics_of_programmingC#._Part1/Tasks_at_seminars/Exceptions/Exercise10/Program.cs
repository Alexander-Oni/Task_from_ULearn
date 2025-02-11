namespace Exercise10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            long test = FindSumWithDivision(1000, 3, 5);
            long test1 = FindSumWithDivision(10000, 9, 2);
            long test2 = FindSumWithDivision(100000, 7, 4);
            long test3 = FindSumWithDivision(1000000, 5, 7);
            long test4 = FindSumWithDivision(10000000, 2, 3);
            Console.WriteLine(test);
            Console.WriteLine(test1);
            Console.WriteLine(test2);
            Console.WriteLine(test3);
            Console.WriteLine(test4);
        }
        static long FindSumWithDivision(long input, long firstDiv, long secondDiv)
        {
            long result = 0;

            for (int i = 0; i < input; i++)
            {
                if (i % firstDiv == 0 || i % secondDiv == 0) result += i;
            }

            return result;
        }
    }
}
