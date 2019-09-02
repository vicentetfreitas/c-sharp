using System;
using System.Collections.Generic;
using System.Text;
using _0083_Heritage.Entities;

namespace _0083_Heritage.Entities
{
    class BusinessAccount : Account
    {
        public double LoanLimit { get; set; }
        public BusinessAccount() { }
        public BusinessAccount(int number, string holder, double balance, double loanLimit)
            : base(number, holder, balance)
        {
            LoanLimit = loanLimit;
        }
        public void Loan(double amount)
        {
            if (amount <= LoanLimit)
            {
                Balance += amount;
            }
            else { }


        }
    }
}
