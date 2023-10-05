using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_Unit_Testing
{
    public abstract class Account
    {
        internal double _balance;

        internal Account(double balance)
        {
            _balance = balance;
        }

        abstract public void Deposit(double amount);
        abstract public void Withdraw(double amount);

    }
}
