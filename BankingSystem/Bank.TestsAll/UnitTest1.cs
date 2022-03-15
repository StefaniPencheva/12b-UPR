using BankingSystem;
using NUnit.Framework;
using System;

namespace Bank.TestsAll
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void AccountnInitilizeWithPositiveValue()
        {
            BanckAccount account = new BanckAccount(2000m);

            Assert.AreEqual(2000m, account.Balance);
        }
        [Test]
        public void DespositShouldAddMoney()
        {
            BanckAccount account = new BanckAccount();

            account.Deposit(50);

            Assert.IsTrue(account.Balance == 50);
        }
        [Test]
        public void PaymentForCreditShouldThrowArgumentExceptionWhenNotEnoughMoney()
        {
            BanckAccount account = new BanckAccount(20);

            Assert.Throws<ArgumentException>(() => account.PaymentForCredit(200));
        }
        [Test]
        public void PaymentForCreditShouldThrowArgumentExceptionWhenPaymentIsNegative()
        {
            BanckAccount account = new BanckAccount(20);

            Assert.Throws<ArgumentException>(() => account.PaymentForCredit(-10));
        }
        [Test]
        public void PaymentForCreditShouldThrowArgumentExceptionWhenPaymentIsZero()
        {
            BanckAccount account = new BanckAccount(20);

            Assert.Throws<ArgumentException>(() => account.PaymentForCredit(0));
        }
        [Test]
        public void IncreaseMethodShouldAddPercentToBalance()
        {
            BanckAccount account = new BanckAccount();
            account.Deposit(100);
            account.Increase(50);
            Assert.AreEqual(150, account.Balance);
        }
        [Test]
        public void IsBonusMethodWorkCorrectly()
        {
            BanckAccount account = new BanckAccount();
            account.Deposit(1100);
            account.Bonus();
            Assert.AreEqual(1200, account.Balance);
        }
    }
}