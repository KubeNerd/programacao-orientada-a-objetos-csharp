using System;
using System.Globalization;

namespace Conversor
{
    public static class Conversor
    {

        static public double contacaoDolar;
        static public int qtdDolar;


        static public string ConversaoDolarReal() {

            double valorApagar = qtdDolar * contacaoDolar;


            return $"O valor a ser pago em reais: R$ {valorApagar.ToString("F2", CultureInfo.InvariantCulture)}";
        
        }

    }
}
