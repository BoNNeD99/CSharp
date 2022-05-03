using System;

namespace HomeWork.Class06.Task01
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] numbers = new double[] { 3, 52, 11.6, -6.3, -60,  3123, 0.5, 43235.2 };

            foreach (double number in numbers)
            {
                NumberStats numberStats = NumberStats(number);
                numberStats.PrintInfo();
            }

            static NumberStats NumberStats(double number)
            {
                NumberStats stats = new NumberStats()
                {
                    Number = number
                };
                stats.isEven = number % 2 == 0;
                stats.isDecimal = number % 1 != 0;
                stats.isNegative = number < 0;
                return stats;
            }
           

            Console.ReadLine();
        }
    }
}
