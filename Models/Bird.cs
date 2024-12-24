using System;

namespace BasicOOPSRevise.Animals
{
    public sealed class Bird : Animal
    {
        public sealed override void MakeSound()
        {
            Console.WriteLine("Bird says: Tweet!");
        }

        public override void Eat(string food)
        {
            if (food.ToLower() == "seeds")
            {
                Console.WriteLine("Bird is pecking at seeds");
            }
            else
            {
                base.Eat(food);
            }
        }

    }

}
