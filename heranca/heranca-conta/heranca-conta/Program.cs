using System;
using heranca_conta.Entities;

namespace herenca_conta
{
    class Program
    {
        static void Main(string[] args)
        {
            
            BusinessAccount businessAccount = new BusinessAccount(8809, "vinicius pereira", 190.00);


            businessAccount.Deposit(100);


            // É pra ter erro mesmo. O balance é protected.

            businessAccount.Balance(200);

            Console.WriteLine(businessAccount);



        }
    }

}