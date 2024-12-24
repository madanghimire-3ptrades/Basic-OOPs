using BasicOOPSRevise.Interfaces;
using System;

namespace BasicOOPSRevise.Models
{
    public class Employee : IPayable
    {
        private string name;
        private decimal salary;
        public Address Address { get; set; }


        public Employee(string name, decimal salary)
        {
            this.name = name;
            this.salary = salary;
        }

        public decimal CalculatePayment()
        {
            return salary;
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"Employee: {name}");
            if (Address != null)
            {
                Console.WriteLine($"Address: {Address.Street}, {Address.City}");
            }
        }
    }
}
