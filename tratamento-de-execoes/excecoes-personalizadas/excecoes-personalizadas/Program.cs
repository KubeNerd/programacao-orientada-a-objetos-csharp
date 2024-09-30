using excecoes_personalizadas.Entities;
using excecoes_personalizadas.Entities.Exceptions;
using System;

namespace excecoes_personalizadas
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Número do quarto: ");
                int number = int.Parse(Console.ReadLine());

                Console.Write("Data de check-in (dd/MM/yyyy): ");
                DateTime checkIn = DateTime.Parse(Console.ReadLine());

                Console.Write("Data de check-out (dd/MM/yyyy): ");
                DateTime checkOut = DateTime.Parse(Console.ReadLine());

                Reservation reservation = new Reservation(number, checkIn, checkOut);
                Console.WriteLine("Reserva: " + reservation);

                Console.WriteLine();
                Console.WriteLine("Entre com os dados para atualizar a reserva:");

                Console.Write("Nova data de check-in (dd/MM/yyyy): ");
                checkIn = DateTime.Parse(Console.ReadLine());

                Console.Write("Nova data de check-out (dd/MM/yyyy): ");
                checkOut = DateTime.Parse(Console.ReadLine());

                reservation.UpdateDates(checkIn, checkOut);
                Console.WriteLine("Reserva atualizada: " + reservation);
            }
            catch (DomainException e)
            {
                Console.WriteLine("Erro na reserva: " + e.Message);
            }
            catch (FormatException e)
            {
                Console.WriteLine("Erro de formatação: " + e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine("Erro inesperado: " + e.Message);
            }
        }
    }
}
