using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Problems;

namespace Tests
{
    public class BankAccountTest
    {
        BankAccount acc;
    // run once before all test cases
    [OneTimeSetUp]
    public void OneTimeSetUp()
    {
        acc = new BankAccount();
        acc.Deposit(1000);
    }

    // test cases
    [Test]
    public void Test_For_Deposit()
    {
        acc.Deposit(500);
        Assert.That(acc.GetBalance(), Is.EqualTo(1500));
    }
    [Test]
    public void Test_For_Withdraw()
    {
        acc.Withdraw(500);
        Assert.That(acc.GetBalance(), Is.EqualTo(1000));
    }
    [Test]
    public void Test_For_Checking_Balance()
    {
        Assert.That(acc.GetBalance(), Is.EqualTo(10000));
    }
    }
}