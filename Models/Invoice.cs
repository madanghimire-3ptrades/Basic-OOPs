using BasicOOPSRevise.Interfaces;

namespace BasicOOPSRevise.Models
{
    public class Invoice : IPayable
    {
        private decimal amount;


        public Invoice(decimal _amount)
        {
            this.amount = _amount;
        }

        public decimal CalculatePayment()
        {
            return amount;
        }

    }
}
