using System;

namespace HomeWork.Class02.Task03.SwapNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            // Swap Numbers
            Console.WriteLine("Swap two numbers");

            int number1, number2, temporary;

            Console.Write("Input First Number:");
            number1 = int.Parse(Console.ReadLine());

            Console.Write("Input Second Number:");
            number2 = int.Parse(Console.ReadLine());

            temporary = number1;
            number1 = number2;
            number2 = temporary;

            Console.WriteLine($"The First Number: {number1}");
            Console.WriteLine($"The Second Number: {number2}");

            Console.ReadLine();
        }
    }
}
