using System;

namespace HomeWork.Class03.Task01.SumOfEven
{
    class Program
    {
        static void Main(string[] args)
        {
            //SumOfEven

            int input, even = 0, odd = 0;

            int[] arrayOfNumbers = new int[6];

            for (input = 0; input < arrayOfNumbers.Length; input++)
            {
                Console.WriteLine("Enter six intagers:");
                arrayOfNumbers[input] = Convert.ToInt32(Console.ReadLine());
            }

            for (input = 0; input < 6; input++)
            {
                if (arrayOfNumbers[input] % 2 == 0)
                {
                    even = even + arrayOfNumbers[input];
                }
                else
                {
                    odd = odd + arrayOfNumbers[input];
                }         
            }

            Console.WriteLine($"The sum of the even intagers is: {even}");
            Console.WriteLine($"The sum of the odd intagers is: {odd}");













            Console.ReadLine();
        }
    }
}
