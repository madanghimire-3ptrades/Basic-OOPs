using System;

namespace BasicOOPSRevise.Models
{
    public class Person
    {
        protected string Name { get; set; }
        protected int Age { get; set; }

        public static int Count { get; set; }

        public Person(string name, int age)
        {
            Name = name;
            Age = age;
            Count++;
        }

        public virtual void Introduce()
        {
            Console.WriteLine($"Hi, I'm {Name} and I'm {Age} years old.");
        }
    }
}
