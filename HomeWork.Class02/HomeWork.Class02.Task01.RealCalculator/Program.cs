using System;

namespace HomeWork.Class02.Task01.RealCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            //Real Calculator
            Console.WriteLine("Real Calculator!");
            Console.WriteLine("Enter the first number:");
            string input = Console.ReadLine();
            Console.WriteLine("Enter the second number:");
            string input2 = Console.ReadLine();


            Console.WriteLine("Chose an operation: +, - , * , /");
            string operation = Console.ReadLine();

            if (operation == "+")
            {
                int.TryParse(input, out int parsedToInt);
                int.TryParse(input2, out int parsedToInt2);
                Console.WriteLine($"The solution is: {parsedToInt + parsedToInt2}");
            }
            else if (operation == "-")
            {
                int.TryParse(input, out int parsedToInt);
                int.TryParse(input2, out int parsedToInt2);
                Console.WriteLine($"The solution is: {parsedToInt - parsedToInt2}");
            }
            else if (operation == "*")
            {
                Double.TryParse(input, out double parsedToDouble);
                Double.TryParse(input2, out double parsedToDouble2);
                Console.WriteLine($"The solution is: {parsedToDouble * parsedToDouble2}");
            }
            else if (operation == "/")
            {
                Double.TryParse(input, out double parsedToDouble);
                Double.TryParse(input2, out double parsedToDouble2);
                Console.WriteLine($"The solution is: {parsedToDouble / parsedToDouble2}");
            }

            Console.ReadLine();
        }
    }
}
