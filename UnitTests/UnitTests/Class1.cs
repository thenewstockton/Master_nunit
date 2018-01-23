using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTests
{
    [TestFixture]
    public class BankAccountTests
    {
        private BankAccount ba;
        [SetUp]
        public void SetUp()
        {
            ba = new BankAccount(100);
        }

        [Test]
        public void BankAccountShouldIncreaseOnPositiveDeposit()
        {
            //Assert.That(2 + 2, Is.EqualTo(4));
            //Assert.Fail("This must fail");
            //Assert.Inconclusive("hello");
            //Assert.Warn("This is not good");
            //Warn.If(2 + 2 != 5);
            //Warn.If(2 + 2, Is.Not.EqualTo(5));
            //Warn.If(() => 2 + 2, Is.Not.EqualTo(5).After(2000));
            //Warn.Unless(2 + 2 == 5);
            //Warn.Unless(2 + 2, Is.EqualTo(5));
            //Warn.Unless(() => 2 + 2, Is.EqualTo(5).After(2000));
            
            ba.Deposit(100);
            //Assert.AreEqual(200, ba.Balance);
            Assert.That(ba.Balance, Is.EqualTo(200));
        }

        [Test]
        public void BankAccountShouldThrowOnNonPositiveAmount()
        {
            var ex = Assert.Throws<ArgumentException>(() =>
            {
                ba.Deposit(-1);
            });

            StringAssert.StartsWith("Deposit amount must be positive", ex.Message);
        }

        [Test]
        public void MultipleAsserts()
        {
            ba.Withdraw(100);

            Assert.Multiple(() =>
            {
                Assert.That(ba.Balance, Is.EqualTo(0));
                Assert.That(ba.Balance, Is.LessThan(1));
            });
            
        }
    }

    public class BankAccount
    {
        public int Balance { get; private set; }

        public BankAccount(int startingBalance)
        {
            Balance = startingBalance;
        }

        public void Deposit(int amount)
        {
            if (amount <= 0)
            {
                throw new ArgumentException("Deposit amount must be positive", nameof(amount));
            }
            Balance += amount;
        }

        public void Withdraw(int amount)
        {
            Balance -= amount;
        }
    }
}
