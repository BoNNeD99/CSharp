using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWork.Class05.Exercise2
{
    public class Dog
    {
        public string Name { get; set; }
        public string Race { get; set; }
        public string Color { get; set; }

        public Dog(string name, string race, string color)
        {
            Name = name;
            Race = race;
            Color = color;
        }

        public void Eat()
        {
            Console.WriteLine($"{Name} is now eating.");
        }
        public void Play()
        {
            Console.WriteLine($"{Name} is now playing.");
        }
        public void ChaseTail()
        {
            Console.WriteLine($"{Name} is now chasing its tail.");
        }
        public DogInfoResult GetDogInfo()
        {
            DogInfoResult dir = new DogInfoResult()
            {
                Name = Name,
                Race = Race,
                Color = Color,
            };
            return dir;
        }

    }
}
