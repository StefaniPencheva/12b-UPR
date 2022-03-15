using System;
using System.Collections.Generic;
using System.Text;

namespace BankingSystem
{
    public class BanckAccount
    {
        private decimal balance;

        public decimal Balance
        {
            get { return this.balance; }
            set { this.balance = value; }
        }
        public BanckAccount(decimal amount = 0)
        {
            this.balance = amount;
        }
        public void Deposit(decimal cash)
        {
            this.balance += cash;
        }
        public void PaymentForCredit(decimal payment)
        {
            if (payment<=0)
            {
                throw new ArgumentException("Payment cannot be zero or negative!");
            }
            if (this.Balance<payment)
            {
                throw new ArgumentException("Not enough money!");
            }
            this.Balance -= payment;
        }
        public void Increase(decimal percent)
        {
            this.balance = this.balance + this.balance * percent / 100;
        }
        public void Bonus()
        {
            if (this.balance > 1000 && this.balance < 2000)
            {
                this.balance = this.balance + 100;
            }
            if (balance >= 2000 && balance <= 3000)
            {
                this.balance = this.balance + 200;
            }
            if (balance > 3000)
            {
                this.balance = this.balance + 300;
            }
        }
    }
}
