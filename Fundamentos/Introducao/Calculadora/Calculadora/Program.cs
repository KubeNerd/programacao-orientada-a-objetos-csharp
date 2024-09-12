using System;  // Importa o namespace base da .NET

class Program  // Define uma classe chamada Program
{
    static void Main(string[] args)  // Método de entrada do programa
    {
        int[] notasAluno = new int[3];  // Array para armazenar as 3 notas
        int counterNotas = 0;

        Console.WriteLine("Digite o nome do aluno:");
        string nomeAluno = Console.ReadLine();

        while (counterNotas < 3)
        {
            Console.WriteLine("Digite aqui a próxima nota do aluno:");
            string notaStr = Console.ReadLine();

            // Tenta converter a string de nota para int
            bool conversaoSucesso = int.TryParse(notaStr, out int nota);

            if (conversaoSucesso && nota >= 0 && nota <= 100)
            {
                notasAluno[counterNotas] = nota;  // Armazena a nota no array
                counterNotas += 1;
                Console.WriteLine($"A nota digitada foi {nota}");
            }
            else
            {
                Console.WriteLine("Nota inválida. Digite um valor numérico entre 0 e 100.");
            }
        }

        // Exibe todas as notas após o loop
        Console.WriteLine($"\nNotas do aluno {nomeAluno}:");
        foreach (int nota in notasAluno)
        {
            Console.WriteLine(nota);
        }


        int somaNotasAluno = (notasAluno[0] + notasAluno[1] + notasAluno[2]) / 3;

        if (somaNotasAluno >= 5)
        {
            Console.WriteLine($"Aluno {nomeAluno} aprovado!\n Média: {somaNotasAluno}");
        } else if (somaNotasAluno < 5) {
            Console.WriteLine($"Aluno {nomeAluno} reprovado!\n Média {somaNotasAluno}");
        } else
        {
            Console.WriteLine("Erro ao tentar avaliar aluno");
        }

    }
}
