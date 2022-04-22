using System;


namespace HomeWork.Class05.Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your name?");
            string Name = Console.ReadLine();
            Console.WriteLine("What is your last name?");
            string LastName = Console.ReadLine();
            Console.WriteLine("How old are you?");
            int Age = Convert.ToInt32(Console.ReadLine());

            Human person = new Human(Name, LastName, Age);
            HumanInfoResults result = person.GetPersonStats();
            Console.WriteLine(string.Format("{0} {1}", result.FullName, result.Age) );


            Console.ReadLine();
        }
    }
}
