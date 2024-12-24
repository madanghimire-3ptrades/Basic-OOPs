namespace BasicOOPSRevise.Models
{
    public interface IPaymentProcessor
    {
        void ProcessPayment(decimal amount);
    }
}
