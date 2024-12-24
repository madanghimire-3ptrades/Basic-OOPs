using System;

namespace BasicOOPSRevise.Vehicles
{
    public class Bicycle : Vehicle
    {
        public Bicycle(string brand) : base(brand) { }

        public override void Start()
        {
            Console.WriteLine($"{Brand} bicycle is ready to ride.");
        }
    }
}
