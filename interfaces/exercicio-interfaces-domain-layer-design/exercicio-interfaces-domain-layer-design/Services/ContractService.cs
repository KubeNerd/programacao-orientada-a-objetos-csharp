using exercicio_interfaces_domain_layer_design.Entities;
using System;
using System.Collections.Generic;

namespace exercicio_interfaces_domain_layer_design.Services
{
    class ContractService
    {
        private IOnlinePaymentService _onlinePaymentService;


        public ContractService(IOnlinePaymentService onlinePaymentService) 
        {

            _onlinePaymentService = paymentService;
        
        }


        public void ProcessContract(Contract contract, int months) 
        {
            double basicQuota = contract.TotalValue / months;

            for (int i = 0; i < months; i++) 
            {
                DateTime date = contract.Date.AddMonths(i);

                double updateQuota = _onlinePaymentService.Interest(basicQuota, i);
            
                double fullQuota = updateQuota + _onlinePaymentService.PaymentFree(updateQuota);


                contract.Installments(new Installment(date, fullQuota));


            }
        }

    }
}
