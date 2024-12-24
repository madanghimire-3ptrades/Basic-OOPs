using System;

namespace BasicOOPSRevise.Vehicles
{
    public abstract class Vehicle
    {
        protected string Brand { get; set; }

        public Vehicle(string brand)
        {
            Brand = brand;
        }

        public abstract void Start();

        public virtual void Stop()
        {
            Console.WriteLine($"{Brand} vehicle stopped.");
        }
    }
}
