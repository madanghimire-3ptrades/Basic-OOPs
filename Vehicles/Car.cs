using System;

namespace BasicOOPSRevise.Vehicles
{
    public class Car : Vehicle
    {
        public Car(string brand) : base(brand) { }


        public override void Start()
        {
            Console.WriteLine($"{Brand} car engine started.");

        }
    }
}
