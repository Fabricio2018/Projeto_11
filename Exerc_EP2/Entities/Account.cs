using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;
using Exerc_EP2.Entities.Exceptions;

namespace Exerc_EP2.Entities
{
    class Account
    {
        public int Number { get; set; }
        public string  Holder { get; set; }
        public double Balance { get; set; }
        public double WithdrawLimit { get; set; }

        public Account()
        { 
        }

        public Account(int number, string holder, double balance, double withdrawLimit)
        {
            Number = number;
            Holder = holder;
            Balance = balance;
            WithdrawLimit = withdrawLimit;
        }

        public void Deposit(double amount)
        {
            Balance += amount;
        }

        public void Withdraw(double amount)
        {
            if (amount > WithdrawLimit)
            {
                throw new DomainExceptions("Withdraw error: The amount exceeds withdraw limit"); 
            }
            else if (amount > Balance)
            {
                throw new DomainExceptions("Not enough balance");
            }

            Balance -= amount;
        }
    }
}
