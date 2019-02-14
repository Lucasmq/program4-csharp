using System;
using System.Collections.Generic;
using System.Text;
using Exception.Entities.Exceptions;

namespace Exception.Entities
{
    class Account
    {
        public int Number { get; set; }
        public string Holder { get; set; }
        public double Balance { get; set; }
        public double WithDrawLimit { get; set; }

        public Account()
        {
        }

        public Account(int number, string holder, double balance, double withDrawLimit)
        {
            Number = number;
            Holder = holder;
            Balance = balance;
            WithDrawLimit = withDrawLimit;
        }

        public void Deposit(double amount)
        {
            Balance += amount;
        }

        public void WithDraw(double amount)
        {
            if (Balance <= 0)
            {
                throw new DomainException("No money in balance!");
            }
            if (amount > WithDrawLimit)
            {
                throw new DomainException("No suficient money!");
            }

            Balance -= amount;
        }
    }
}
