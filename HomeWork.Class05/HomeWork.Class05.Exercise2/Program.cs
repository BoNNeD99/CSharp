using System;

namespace HomeWork.Class05.Exercise2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your dogs name:");
            string name = Console.ReadLine();
            Console.WriteLine("Enter your dogs race:");
            string race = Console.ReadLine();
            Console.WriteLine("Enter your dogs color:");
            string color = Console.ReadLine();

            Dog dog = new Dog(name, race, color);

            Console.WriteLine("Enter a number to chose what your dog needs to do:");
            Console.WriteLine("1. Eat.");
            Console.WriteLine("2. Play.");
            Console.WriteLine("3. Chase its Tail.");
            Console.WriteLine("4. Print the dogs info.");

            string action = Console.ReadLine();
            int.TryParse(action, out int actionParsed);


            if (actionParsed == 1)
            {
                dog.Eat();
            }
            if (actionParsed == 2)
            {
                dog.Play();
            }
            if (actionParsed == 3)
            {
                dog.ChaseTail();
            }
            if (actionParsed == 4)
            {
                DogInfoResult result = dog.GetDogInfo();
                Console.WriteLine("{0} {1} {2}",$"The dogs name is: {result.Name},", $"The dogs race is:{result.Race},", $"The dogs color is:{result.Color}.");
            }

            Console.ReadLine();
        }
    }
}
