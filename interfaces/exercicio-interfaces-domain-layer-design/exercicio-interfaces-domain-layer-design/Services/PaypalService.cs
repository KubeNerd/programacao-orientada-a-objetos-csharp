using System;
using System.Collections.Generic;

namespace exercicio_interfaces_domain_layer_design.Services
{
    class PaypalService: IOnlinePaymentService
    {
        private const double InterestRate = 0.01;
        private const double FeePercentage = 0.02;
    
        public double Interest(double amount, int months) 
        {
            return amount * InterestRate * months;
        }

        public double PaymentFee(double amount)
        {
            return amount * FeePercentage;
        }

    }
}
