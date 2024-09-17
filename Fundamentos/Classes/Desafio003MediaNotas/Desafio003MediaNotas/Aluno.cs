using System;
using System.Globalization;


namespace Desafio003MediaNotas
{
    internal class Aluno
    {
        public string NomeAluno;
        public double PrimeiraNota;
        public double SegundaNota;
        public double TerceiraNota;

        public string CalculaMediaAluno() {

            double MediaAprovacao = 6.00;

            double SomaNotas = PrimeiraNota + SegundaNota + TerceiraNota / 3;

            if (SomaNotas >= MediaAprovacao)
            {

                return "O aluno, "
                    + NomeAluno
                    + " foi APROVADO, com média: "
                    + $"{SomaNotas:F2}";

            }
            else {

                return "O aluno"
                + NomeAluno
                + " foi REPROVADO, com média: "
                + $"{SomaNotas:F2}";

            }


        }
    }
}
