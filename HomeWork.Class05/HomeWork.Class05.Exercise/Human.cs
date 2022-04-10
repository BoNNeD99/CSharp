using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWork.Class05.Exercise
{
    class Human
    {
        public string Name { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }

        public Human(string name, string lastName, int age)
        {
            Name = name;
            LastName = lastName;
            Age = age;
        }

        public HumanInfoResults GetPersonStats()
        {
            HumanInfoResults hir = new HumanInfoResults()
            {
                Age = Age,
                FullName = string.Format("{0} {1}", Name, LastName),
            };
            return hir;
        }

        




    }
}
