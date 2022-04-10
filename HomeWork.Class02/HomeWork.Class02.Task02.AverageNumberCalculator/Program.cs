using System;

namespace HomeWork.Class02.Task02.AverageNumberCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Average Number Calculator!");
            Console.WriteLine("Enter 4 Numbers:");

            double num1, num2, num3, num4;
            Console.Write("Enter the First number: ");
            num1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter the Second number: ");
            num2 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter the Third number: ");
            num3 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter the Fourth number: ");
            num4 = Convert.ToDouble(Console.ReadLine());

            double result = (num1 + num2 + num3 + num4) / 4;
            Console.WriteLine($"The average of the 4 numbers is: {result}");
            Console.ReadLine();
        }
    }
}
