using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PercentCount
{
    internal class Program
    {
        static void Main(string[] args)
        {
        }

        static double CalculatePersentOFDeposit(string stringValue)
        {
            double[] resultValue = stringValue.Split(' ').Select(double.Parse).ToArray();

            double deposit = resultValue[0];
            double depositPersent = resultValue[1];
            double month = resultValue[2];

            return deposit * Math.Pow((1 + depositPersent / (12 * 100)), month);
        }
    }
}

