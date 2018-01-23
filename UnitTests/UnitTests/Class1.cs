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
        [Test]
        public void BankAccountShouldIncreaseOnPositiveDeposit()
        {
            
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

        }

        public void Withdraw(int amount)
        {

        }
    }
}
