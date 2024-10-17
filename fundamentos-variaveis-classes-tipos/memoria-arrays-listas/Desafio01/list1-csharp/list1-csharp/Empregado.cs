namespace list1_csharp
{
    class Empregado
    {
        public int Id { get; set; }
        public string Nome { get; set; }

        public double Salario { get; private set; }

        public Empregado(int id, string nome, double salario)
        {

            Id = id;
            Nome = nome;
            Salario = salario;

        }

        public void AumentoSalario(double percentual)
        {
            Salario += percentual / 100.00;
        }


        public override string ToString()
        {

            return Id
                + Nome
                + Salario;
        }
    }

}
