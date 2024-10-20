using exercicios_delegate.Services;
using System;

delegate void BinaryNumericOperation(double n1, double n2);
public class Program
{
    public static void Main(string[] args)
    {
        double a = 10;
        double b = 12;

        BinaryNumericOperation op = CalculateService.ShowSum;

        op += CalculateService.ShowMax;


        op.Invoke(a, b);
    }
}