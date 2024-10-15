using System;
using exercicio_arquivos.Services;

namespace exercicio_arquivos.Services
{
    class ServiceCalculate: IServiceCalculate 
    { 
        public double Total(double price, int quantity)
        {
            return price * quantity;
        }
    }

}
