using System;

namespace Exersice1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Enter first variable: ");
                int variable1 = int.Parse(Console.ReadLine());

                Console.WriteLine("Enter second variable: ");
                int variable2 = int.Parse(Console.ReadLine());

                string test = VariableReplace(variable1, variable2);
                Console.WriteLine(test);
            }
        }

        static string VariableReplace(int firstVar, int secondVar)
        {
            int tempVar = firstVar;
            firstVar = secondVar;
            secondVar = tempVar;

            return "Now first variable is " + firstVar + " and second variable is " + secondVar; 
        }
    }

}
