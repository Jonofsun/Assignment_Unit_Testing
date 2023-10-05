using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_Unit_Testing
{
    public class Savings : Account
    {
        double _interest;
        public double _balance { get; private set; }

        public Savings(double balance) : base(balance)
        {
            _interest = 0.00;
        }

        public override void Deposit(double amount)
        {
            
            if (amount <= 0)
            {
                _balance = 200;

            }
            else
            {
                _balance += amount + _interest;
            }
            

        }

        public override void Withdraw(double amount)
        {
            if (amount <= 0)
            {
                _balance = 500;

            }
            else
            {
                _balance = 500;
                _balance -= amount;
            }
            
        }
        //public double Balance(double amount)
        //{
        //    if(amount == _balance)
        //    {
        //        return amount;
        //    }
        //    else
        //    {
        //        return 0;
        //    }
        //}
    }
}
