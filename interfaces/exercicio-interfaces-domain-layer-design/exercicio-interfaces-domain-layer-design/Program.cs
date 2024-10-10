using exercicio_interfaces_domain_layer_design.Entities;
using exercicio_interfaces_domain_layer_design.Services;
using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter contract data");
        Console.Write("Number: ");
        int number = int.Parse(Console.ReadLine());

        Console.Write("Date (dd/MM/yyyy): ");
        DateTime date = DateTime.Parse(Console.ReadLine());

        Console.Write("Contract value: ");
        double totalValue = double.Parse(Console.ReadLine());

        Console.Write("Enter number of installments: ");
        int installments = int.Parse(Console.ReadLine());


        Contract contract = new Contract { Number = number, Date = date, TotalValue = totalValue };

   
        ContractService contractService = new ContractService(new PaypalService());

        contractService.ProcessContract(contract, installments);

        Console.WriteLine("Installments:");
        foreach (var installment in contract.Installments)
        {
            Console.WriteLine($"{installment.DueDate:dd/MM/yyyy} - {installment.Amount:F2}");
        }
    }
}