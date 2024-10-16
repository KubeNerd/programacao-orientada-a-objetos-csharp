using System;

namespace exercicio_membros_estaticos
{
    static class DollarCalculator
    {

        public static double DollarQuote {  get; set; }
        public static int DollarQuantity { get; set; }

        private static readonly double IOF = 6;

        public static double Total() {
            double processCalculateResult = DollarQuote * DollarQuantity;
            double processPercentual = processCalculateResult / 100 * IOF;
            double processTotal = processCalculateResult + processPercentual;

            return processTotal;


        }
    }
}