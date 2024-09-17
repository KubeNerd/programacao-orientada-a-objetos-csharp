
## 1. Sobrecarga
- **Sobrecarga** permite criar múltiplos métodos com o mesmo nome, mas com diferentes assinaturas (tipos e quantidade de parâmetros).
- Exemplo:
    ```csharp
    public class Calculadora
    {
        public int Somar(int a, int b) => a + b;

        public double Somar(double a, double b) => a + b;

        public int Somar(int a, int b, int c) => a + b + c;
    }
    ```
- Permite que os métodos se comportem de forma diferente dependendo dos parâmetros fornecidos.

## 2. Encapsulamento
- **Encapsulamento** é o conceito de esconder os detalhes internos da implementação de uma classe, expondo apenas o que é necessário.
- Isso é feito com o uso de modificadores de acesso (`public`, `private`, `protected`, etc.).
- Exemplo:
    ```csharp
    public class Pessoa
    {
        private string nome;

        public void SetNome(string nome)
        {
            if (!string.IsNullOrEmpty(nome))
            {
                this.nome = nome;
            }
        }

        public string GetNome()
        {
            return nome;
        }
    }
    ```

## 3. Construtores
- **Construtores** são métodos especiais chamados quando um objeto de uma classe é criado.
- Eles têm o mesmo nome da classe e não possuem tipo de retorno.
- Exemplo:
    ```csharp
    public class Carro
    {
        public string Marca { get; set; }

        // Construtor
        public Carro(string marca)
        {
            Marca = marca;
        }
    }
    ```
- Também é possível ter **sobrecarga** de construtores, criando múltiplos construtores com diferentes parâmetros.

## 4. `this`
- A palavra-chave **`this`** faz referência à instância atual da classe.
- É usada para diferenciar os membros da classe (campos, propriedades) de parâmetros com o mesmo nome.
- Exemplo:
    ```csharp
    public class Produto
    {
        private string nome;

        public Produto(string nome)
        {
            this.nome = nome; // 'this' refere-se ao campo da classe, não ao parâmetro
        }
    }
    ```

## 5. Properties
- **Properties** (propriedades) são usadas para acessar e modificar os campos de uma classe, fornecendo um nível de encapsulamento.
- Elas podem incluir lógica para validação ou processamento adicional.
- Exemplo:
    ```csharp
    public class Pessoa
    {
        private int idade;

        public int Idade
        {
            get { return idade; }
            set
            {
                if (value >= 0)
                {
                    idade = value;
                }
            }
        }
    }
    ```

## 6. Auto-Properties
- **Auto-Properties** são propriedades que não necessitam de um campo explícito para armazenamento de dados. O compilador cria um campo privado automaticamente.
- Simplifica o código quando não há necessidade de lógica extra no `get` e `set`.
- Exemplo:
    ```csharp
    public class Livro
    {
        public string Titulo { get; set; } // Auto-Property
    }
    ```

## 7. Membros Estáticos
- **Membros Estáticos** pertencem à classe e não a instâncias específicas. Podem ser acessados diretamente pela classe, sem a necessidade de criar um objeto.
- Usados para definir comportamentos ou propriedades que são comuns a todas as instâncias.
- Exemplo:
    ```csharp
    public class Calculadora
    {
        public static double PI = 3.14159;

        public static double Somar(double a, double b)
        {
            return a + b;
        }
    }
    ```

