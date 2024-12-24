using System;

namespace BasicOOPSRevise.Animals
{
    public class Cat : Animal
    {
        public override void MakeSound()
        {
            Console.WriteLine("Cat says: Meow!");
        }

        public override void Eat(string food)
        {
            if (food.ToLower() == "fish")
            {
                Console.WriteLine("Cat is eating fish with delight");
            }
            else
            {
                Console.WriteLine("Cat sniffs the food and walks away");
            }
        }

        public override int GetAge()
        {
            return 5;
        }
    }
}
