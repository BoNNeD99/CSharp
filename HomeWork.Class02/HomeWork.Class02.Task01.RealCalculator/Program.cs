using System;

namespace HomeWork.Class02.Task01.RealCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Real Calculator!");
            //First number input.
            Console.WriteLine("Enter the first number:");
            bool parsingNum1 = double.TryParse(Console.ReadLine(), out double num1);

            //Second number input.
            Console.WriteLine("Enter the second number:");
            bool parsingNum2 = double.TryParse(Console.ReadLine(), out double num2);

            //Operation selection.
            Console.WriteLine("Select and operation ( +, -, *, /):");
            string selestion = Console.ReadLine();

            //While one of the selected options is not selected the program will print warning message then stops.
            while (selestion != "+" && selestion != "-" && selestion != "*" && selestion != "/")
            {
                Console.WriteLine("There is not such an option! Please try again!");
                break;
            }
            //While one of the inputs is not a number the program will print warning message then stops.
            while (!parsingNum1 || !parsingNum2)
            {
                Console.WriteLine("Please enter valid number inputs !");
                break;
            }

            //While bouth inputs are numbers the operation will funcion.
            while (parsingNum1 && parsingNum2)
            {
                if (selestion == "+")
                {
                    double resultSum = num1 + num2;
                    Console.WriteLine($"{num1} + {num2} = {resultSum}");
                }
                if (selestion == "-")
                {
                    double resultSubstract = num1 - num2;
                    Console.WriteLine($"{num1} - {num2} = {resultSubstract}");
                }
                if (selestion == "*")
                {
                    double resultMultiply = num1 * num2;
                    Console.WriteLine($"{num1} * {num2} = {resultMultiply}");
                }
                if (selestion == "/")
                {
                    double resultDevide = num1 / num2;
                    Console.WriteLine($"{num1} / {num2} = {resultDevide}");
                }
                break;
            }

            Console.ReadLine();
        }
    }
}
