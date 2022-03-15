using NUnit.Framework;
//using BanckingSystem;
using System;

namespace BanckAccountTests
{
    [TestFixture]
    public class BanckAccount.Test
    {
        [Test]
        public void AccountnInitilizeWithPositiveValue()
        {
            BanckAccount account = new BanckAccount(2000m);

            Assert.AreEqual(2000m, account.Balance);
        }
        [Test]
        public void Desposit
    }
}