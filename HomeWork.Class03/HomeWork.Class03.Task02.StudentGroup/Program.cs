using System;

namespace HomeWork.Class03.Task02.StudentGroup
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] studentG1 = new string[]
            {
                "Mario",
                "Goran",
                "Stojan",
                "Ana",
                "Marija",
            };
            string[] studentG2 = new string[]
            {
                "Zoran",
                "Elvir",
                "Slatkar",
                "Ilija",
                "Beti",
            };

            Console.WriteLine("Enter a student group: (there are 1 and 2 ).");
            int input = Convert.ToInt32(Console.ReadLine());

            if (input == 1)
            {
                int i = input;
                for (i = 0; i < studentG1.Length; i++)
                {
                    
                    Console.WriteLine($"The students from group 1 are: {studentG1[i]} ");
                }
            }
            if (input == 2)
            {
                int i = input;
                for (i = 0; i < studentG1.Length; i++)
                {
                    Console.WriteLine();
                    Console.WriteLine($"The students from group 1 are: {studentG2[i]} ");
                }
            }


        }
    }
}
