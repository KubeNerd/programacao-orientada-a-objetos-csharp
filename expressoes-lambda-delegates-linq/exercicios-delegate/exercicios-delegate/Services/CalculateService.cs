using System;

namespace exercicios_delegate.Services
{
    class CalculateService
    {
        public  static double Max(double x, double y) 
        {

            return (x > y) ? x : y;
        }
        public static void ShowMax(double x, double y)
        {
            double max = (x > y) ? x : y;
            Console.WriteLine(max);
        }

        public static void ShowSum(double x, double y)
        {
            double sum = x + y;
            Console.WriteLine(sum);
        }
    }
}
