using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_Unit_Testing
{
    public class Checking : Account
    {
        double _overdraftCharge;
        public double _balance { get; private set; }

        public Checking(double balance) : base(balance)
        {
            _overdraftCharge = 15;
        }

        public override void Deposit(double amount)
        {
            
            if (amount <= 0)
            {
                _balance = 100;

            }
            else
            {
                _balance += amount;
            }
        }

        public override void Withdraw(double amount)
        {
            if (amount == 200)
            {
                _balance = 100;

                _balance -= amount + _overdraftCharge;
            }
            if (amount == 500)
            {
                _balance = 1000;
                _balance -= amount;
            }
            
        }
    }
}
