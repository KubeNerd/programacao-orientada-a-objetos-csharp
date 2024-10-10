using System;
using System.Collections.Generic;

namespace exercicio_interfaces_domain_layer_design.Services
{
    interface IOnlinePaymentService
    {
        double Interest(double interest);
        double PaymentFree(double interest);
    }
}
