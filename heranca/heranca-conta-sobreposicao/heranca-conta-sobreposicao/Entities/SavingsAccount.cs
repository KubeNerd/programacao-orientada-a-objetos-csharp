using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace herenca_conta_sobreposicao.Entities
{
    class SavingsAccount : Account
    {
        public double InterestRate {  get; set; }
        public SavingsAccount() 
        {
        
        }

        public SavingsAccount(int number, string holder, double balance, double interestRate) 
            : base(number, holder, balance)
        { 
            InterestRate = interestRate;
        }


        public void UpdateBalance() 
        {
            Balance += Balance * InterestRate;        
        }



        override void WhitDraw(double amount){
            base.WithDraw(amount);
            UpdateBalance -= 2.0;
        }
    }
}
