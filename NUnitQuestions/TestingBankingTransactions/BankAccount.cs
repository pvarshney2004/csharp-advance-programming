using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace TestingBankingTransactions
{
    public class BankAccount
    {
        /*
        1. Testing Banking Transactions
Problem:
Create a BankAccount class with:
● Deposit(double amount): Adds money to the balance.
● Withdraw(double amount): Reduces balance.
● GetBalance(): Returns the current balance.
✅ Write unit tests to check correct balance updates.
✅ Ensure withdrawals fail if funds are insufficient.
        */

        private double balance; // private data fields

        // public getter and setter for balance
        public double Balance
        {
            get
            {
                return balance;
            }
            set
            {
                if (value < 0)
                {
                    System.Console.WriteLine("balance cannot be negative");
                    return;
                }
                balance = value;
            }
        }

        // method to deposit money
        public void Deposit(double amount)
        {
            if (amount <= 0)
            {
                return;
            }
            balance += amount;
        }

        // method to withdraw money
        public bool Withdraw(double amount)
        {
            if (amount > Balance) return false;
            balance -= amount;
            return true;
        }
        // method to get current balance
        public double GetBalance()
        {
            return balance;
        }
    }
}