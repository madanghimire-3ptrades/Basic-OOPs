using System;

namespace BasicOOPSRevise.Animals
{

    public class Dog : Animal
    {
        public override void MakeSound()
        {
            Console.WriteLine("Dog says: Woof!");
        }

        public override void Eat(string food)
        {
            if (food.ToLower() == "bone")
            {
                Console.WriteLine("Dog is happily chewing the bone");
            }
            else
            {
                base.Eat(food);
            }
        }

        public override int GetAge()
        {
            return 7;
        }

        public override string Species
        {
            get { return "Canis lupus familiaris"; }
            set { base.Species = value; }
        }
    }

}
