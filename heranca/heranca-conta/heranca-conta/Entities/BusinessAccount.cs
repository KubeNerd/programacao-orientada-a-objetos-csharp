using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace heranca_conta.Entities
{
    class BusinessAccount : Account
    {
        public double LoanLimit { get; set; }


        public BusinessAccount() 
        {

        }

        public BusinessAccount(int number, string holder, double loanLimit)
           : base(number, holder, loanLimit)
        {

            LoanLimit = loanLimit;

        }

        public void Loan(double amount) 
        {
            if (amount <= LoanLimit)
            { 
               Balance += amount;
            }
        }

    }
}
