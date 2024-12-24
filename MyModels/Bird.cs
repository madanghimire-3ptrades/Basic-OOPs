using BasicOOPSRevise.Interfaces;
using System;

namespace BasicOOPSRevise.MyModels
{
    public class Bird : IFlyable
    {
        public void Fly()
        {
            Console.WriteLine("Bird is flying");

        }
    }
}
