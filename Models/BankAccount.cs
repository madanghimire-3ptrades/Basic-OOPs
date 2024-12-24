using System;

namespace BasicOOPSRevise.Models
{
    public class BankAccount
    {
        private string accountNumber;
        private decimal balance;

        public decimal Balance
        {
            get { return balance; }
            private set { balance = value; }
        }

        public BankAccount(string accNum, decimal initialBalance)
        {
            accountNumber = accNum;
            Balance = initialBalance;
        }

        public void Deposit(decimal amount)
        {
            if (amount > 0)
            {
                Balance += amount;
                Console.WriteLine($"Deposited ${amount}");

            }
        }

        public void WithDraw(decimal amount)
        {
            if (amount <= Balance && amount > 0)
            {
                Balance -= amount;
                Console.WriteLine($"Withdrawn ${amount}");
            }
        }
    }
}
