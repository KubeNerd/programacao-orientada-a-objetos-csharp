using System;

namespace Conversor {


    class Program {

        public static void Main(string[] args) {


            Console.WriteLine("Qual é a contação do dolar ?");
            Conversor.contacaoDolar = double.Parse(Console.ReadLine()) ;


            Console.WriteLine("Quantos dolares você deseja comprar ?");
            Conversor.qtdDolar = int.Parse(Console.ReadLine());


            Console.WriteLine(Conversor.ConversaoDolarReal());



        }
        
    };

};