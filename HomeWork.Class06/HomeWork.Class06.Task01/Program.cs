using System;

namespace HomeWork.Class06.Task01
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Please Enter a number: ");

            if (int.TryParse(Console.ReadLine(), out int input))
            {
                double[] numbers = new double[] { input };
                foreach (double number in numbers)
                {
                NumberStats numberStats = NumberStats(number);
                numberStats.PrintInfo();
                }

            }else
            {
                Console.WriteLine("This is not a number!");
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
