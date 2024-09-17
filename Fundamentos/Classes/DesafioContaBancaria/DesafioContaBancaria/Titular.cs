using System;

class Titular
{
    public string NomeCompleto { get; private set; }
    public double Idade { get; private set; }
    public string Cpf { get; private set; }
    public string Codigo { get; private set; }

    public Titular() { }


    public Titular(string nome, string cpf, double idade)
    {
        NomeCompleto = nome;
        Cpf = cpf;
        Idade = idade;
    }


    public void SetNomeCompletoTitular(string nome)
    {
        if (!string.IsNullOrEmpty(nome))
        {
            NomeCompleto = nome;
        }
        else
        {
            Console.WriteLine("Nome inválido.");
        }
    }

    public string GetNomeCompletoTitular()
    {
        return NomeCompleto;
    }

}


