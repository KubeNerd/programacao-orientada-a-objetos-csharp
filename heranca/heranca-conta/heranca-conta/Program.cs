using System;
using heranca_conta.Entities;

namespace herenca_conta
{
    class Program
    {
        static void Main(string[] args)
        {

            //BusinessAccount businessAccount = new BusinessAccount(8809, "vinicius silva", 190.00);


            //businessAccount.Deposit(100);


            //// É pra ter erro mesmo. O balance é protected.

            //businessAccount.Balance(200);

            //Console.WriteLine(businessAccount);


            Account acc = new Account(1001, "Alex", 0.0);
            BusinessAccount bacc = new BusinessAccount(1002, "Maria", 0.0, 500.0);

            // Upcasting

            Account acc1 = bacc;
            Account acc2 = new BusinessAccount(1003, "Bob", 0.0, 200.0);
            Account acc3 = new SavingsAccount(1004, "Anna", 0.0, 0.01);


            // Downcasting
            BusinessAccount acc4 = (BusinessAccount)acc2;
            acc4.Loan(1000);


            BusinessAccount acc5 = (BusinessAccount)acc3;


        }
    }

}