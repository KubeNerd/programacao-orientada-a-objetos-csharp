using System;
using heranca_conta.Entities;

namespace herenca_conta_sobreposicao
{
    class Program
    {
        static void Main(string[] args)
        {
            Account acc1 = new Account(1001, "Vinicius P", 500.0);
            Account acc2 = new SavingsAccount(1002, "Anna", 500.0, 0.01);
        }
    }

}