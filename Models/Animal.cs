using System;

namespace BasicOOPSRevise.Animals
{

    public class Animal
    {
        public string Name { get; set; }

        public virtual void MakeSound()
        {
            Console.WriteLine("Animal makes a sound");
        }

        public virtual void Eat(string food)
        {
            Console.WriteLine($"Animal is eating {food}");
        }

        public void Sleep()
        {
            Console.WriteLine("Animal is sleeping");
        }

        public virtual int GetAge()
        {
            return 0;
        }

        public virtual string Species { get; set; }
    }

}
