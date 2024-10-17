# Valor padrão

- QUando alocamos (new) qualquer tipo estruturado (classe, struct, array), são atribuídos valores padrão aos elementos


    - números: 0
    - bool: False
    - char: caractere código 0
    - objeto: null

- Lembrando: uma variável apenas declarada, mas não instanciada, inicia em estado "não atribuída", e o próprio compilador não permite que ela seja acessada.


## Tipo de referência vs. tipo de valor

Claro! Aqui está a tabela comparativa entre **Classe** e **Struct** em um formato que você pode copiar facilmente. 

### Tabela Comparativa entre Classe e Struct

| **Características**                     | **Classe**                                                                 | **Struct**                                        |
|-----------------------------------------|----------------------------------------------------------------------------|---------------------------------------------------|
| **Vantagem**                            | Usa todos os recursos de Programação Orientada a Objetos (POO)             | Mais simples e mais performático                   |
| **Alocação de Variáveis**               | Variáveis são ponteiros                                                     | Variáveis são caixas                               |
| **Instanciação de Objetos**             | Objetos precisam ser instanciados usando `new` ou apontar para um objeto já existente | Não é preciso instanciar usando `new`, mas é possível |
| **Aceita valor null**                   | Sim                                                                        | Geralmente não (depende da linguagem)              |
| **Suporte a Herança**                   | Sim                                                                        | Limitado ou inexistente (depende da linguagem)     |
| **Atribuição (Exemplo: Y = X)**         | Y passa a apontar para onde X aponta                                       | Y copia o valor de X                               |
| **Local de Instanciação**               | Heap                                                                       | Stack (geralmente)                                 |
| **Gerenciamento de Memória**            | Objetos não utilizados são desalocados pelo garbage collector              | Alocação e desalocação mais eficiente              |

### Formato CSV para Copiar e Colar

Você também pode usar o seguinte formato CSV para importar a tabela em programas como Excel ou Google Sheets:

```csv
"Características","Classe","Struct"
"Vantagem","Usa todos os recursos de Programação Orientada a Objetos (POO)","Mais simples e mais performático"
"Alocação de Variáveis","Variáveis são ponteiros","Variáveis são caixas"
"Instanciação de Objetos","Objetos precisam ser instanciados usando `new` ou apontar para um objeto já existente","Não é preciso instanciar usando `new`, mas é possível"
"Aceita valor null","Sim","Geralmente não (depende da linguagem)"
"Suporte a Herança","Sim","Limitado ou inexistente (depende da linguagem)"
"Atribuição (Exemplo: Y = X)","Y passa a apontar para onde X aponta","Y copia o valor de X"
"Local de Instanciação","Heap","Stack (geralmente)"
"Gerenciamento de Memória","Objetos não utilizados são desalocados pelo garbage collector","Alocação e desalocação mais eficiente"
```

### Instruções para Usar o CSV

1. **Copie** o texto dentro do bloco ```csv``` acima.
2. **Abra** o Excel, Google Sheets ou qualquer outro editor de planilhas.
3. **Cole** o conteúdo diretamente na planilha.
4. O programa deve reconhecer automaticamente as colunas e linhas, organizando a tabela conforme esperado.

### Visualização da Tabela

Para facilitar a visualização, aqui está a tabela novamente em Markdown:

| **Características**                     | **Classe**                                                                 | **Struct**                                        |
|-----------------------------------------|----------------------------------------------------------------------------|---------------------------------------------------|
| **Vantagem**                            | Usa todos os recursos de Programação Orientada a Objetos (POO)             | Mais simples e mais performático                   |
| **Alocação de Variáveis**               | Variáveis são ponteiros                                                     | Variáveis são caixas                               |
| **Instanciação de Objetos**             | Objetos precisam ser instanciados usando `new` ou apontar para um objeto já existente | Não é preciso instanciar usando `new`, mas é possível |
| **Aceita valor null**                   | Sim                                                                        | Geralmente não (depende da linguagem)              |
| **Suporte a Herança**                   | Sim                                                                        | Limitado ou inexistente (depende da linguagem)     |
| **Atribuição (Exemplo: Y = X)**         | Y passa a apontar para onde X aponta                                       | Y copia o valor de X                               |
| **Local de Instanciação**               | Heap                                                                       | Stack (geralmente)                                 |
| **Gerenciamento de Memória**            | Objetos não utilizados são desalocados pelo garbage collector              | Alocação e desalocação mais eficiente              |


## Nullable

- É um recurso de c# para que dados de tipo valor(structs) possam receber o valor null

- Uso comum:
    - Campos de banco de dados que podem valer nulo(data de nascimento, algum valor numérico)
    - Dados e parâmetros opcionais.


```csharp
namespace Course {
    class Program {
        static void Main(string[] args){
            double? x = null;
            double? x = 10.0;


            Console.WriteLine(x.GetValueOrDefault());
            Console.WriteLine(y.GetValueOrDefault());

            Console.WriteLine(x.HashValue);

            double a = x ?? 5;
            double b = y ?? 6;
            
        }
    }
}


```


## Vetores

- Em programação, "vetor" é o nome dado a arranjos unimemencionais
- Arranjo é uma estrutura de dados:
    - Homogênea(dados do mesmo tipo)
    - Ordenada(elementos acessados por meio de posições)
    - Alocada de uma vez só em um bloco continuo de memória

- Vantagens:
    - Acesso imediato aos elementos pela posição
    
- Desvantagens:
    - Tamanho fixo
    - Dificuldade para se realizar inserções e deleções

```csharp
using System;

public class Course
{
    public static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        double[] vect = new double[n];

        for (int i = 0; i < n; i++){
            vect[i] = double.Parse(Console.ReadLine());
        }
    } 
}

```


```csharp
using System.Globalization;
using System;

public class Product {
    public string Name;
    public double Price;
    
    public Product(){
        
    }
}
public class Vetores
{
    public static void Main(string[] args)
    {
       int n = int.Parse(Console.ReadLine());
        
       Product[] vect = new Product[n];
        
       for(int i=0; i< n; i++){
           string name = Console.ReadLine();
           double preco = Console.ReadLine();
           
           vect[i] = new Product {
               Name = name,
               Price = preco
           };
       }
        
        double sum = 0.0;
        
        for (int i = 0; i < n; i++){
            sum += vect[i].Price;
        };
        
        double avg = sum / n;
        Console.WriteLine(avg);
    }
}

```

```csharp
using System;

public class Student {
    
    public string Name { get; set; }
    public string Email { get; set; }
    
    public Student(string name, string email){
        Name = name;
        Email = email;
    }
}



public class Locator: Student {
  public Room RentedRoom { get; set; }
  
  public Locator(string name, string email, Room rentedRoom): base(name, email){
      RentedRoom = rentedRoom;
  }
}

public class Room {
    public int Number { get; set; }
    public double Price { get; set; }
    public bool IsAvalaible { get; private set; }
    
    
    public Room(){}
}

public class Rental {
    public static void Main(string[] args) {
        Room[] rooms = new Room[10];

        for (int i = 0; i < 10; i++) {
            rooms[i] = new Room(i + 1, 1200.00);
        }

        Console.Write("Digite o número de estudantes que vão alugar os quartos: ");
        int n = int.Parse(Console.ReadLine());

        Locator[] locators = new Locator[n];

        for (int i = 0; i < n; i++) {
            Console.Write($"Digite o nome do estudante {i + 1}: ");
            string name = Console.ReadLine();
            Console.Write($"Digite o email do estudante {i + 1}: ");
            string email = Console.ReadLine();

            Room availableRoom = Array.Find(rooms, room => room.IsAvailable);

            if (availableRoom != null) {
                locators[i] = new Locator(name, email, availableRoom);
                availableRoom.Rent(); 
                Console.WriteLine($"Quarto {availableRoom.Number} alugado para {name}.");
            } else {
                Console.WriteLine("Não há quartos disponíveis.");
            }
        }

        Console.WriteLine("Processo de aluguel finalizado.");
    }
}
```


## Motificadores de parametros params

```csharp
namespace Course {
    class Calculator {
        public static int Sum(params int[] numbers){
            int sum = 0;
            for(int i = 0; i < numbers.Length; i++>){
                sum += numbers[i];
            }
            return sum;
        }
    }
}
```


## Motificadores de parametro ref

```csharp
class Calculator {
    public static void Tripe(ref int x){
        x = x * 3;
    }
}

class Program {
    static void Main(string[] args){
        int a = 10;
        Calculator.Tripe(ref a);
        Calculator.WriteLine(a);
    }
}

```


## Motificadores de parametro out

```csharp
 class Calculator {
    public static void Triple(int origin, out int result){
        result = origin * 3;

    }
 }

 class Program {
    static void Main(string[] args){
        int a = 10;
        int triple;
        Calculator.Triple(a, out triple);
        Console.WriteLine(triple);
    }
 }

```


## Boxing e Unboxing

```csharp
int number = 42;
object boxedNumber = number; // Boxing

```
**Boxing**: Converte um tipo de valor para um tipo de referência.
**Unboxing**: Converte um tipo de referência de volta para um tipo de valor.


## Foreach - Opcional

```csharp
// Online C# Editor for free
// Write, Edit and Run your C# code using C# Online Compiler

using System;

public class Foreatch
{
    public static void Main(string[] args)
    {
        string[] nomes = new string[] {"vinicus", "pereira", "teste"};
        
        for(int n = 0; n < nomes.Length; n++){
            Console.WriteLine(nomes[n]);
        }
    }
}

Console.WriteLine("---------");

foreach(string obje in vect){
    Console.WriteLine(obj);
}

```

## Listas
```csharp
   using System;
   using System.Collections.Generic;

    List<string> list = new List<string>();
    List<string> list2 = new List<string>{"vinicius", "teste"};
    /*O Add insere por padrão no final da lista*/
    list2.Add("Teste 2");
    /*O Insert permite selecionar/decidir em qual posição da lista o valor será inserido*/
    list2.Insert(4,"Teste 3");

```

## Encontrar valores em listas
```csharp
    List<string> nomes = new List<string>{"jhonn", "maria"};

    static bool Test(string s){
        return s[0] == "j";
    }


    string s1 = list.Find(j => j[0] == "j");

    Console.WriteLine(s1);
```

```csharp
    List<string> lista = new List<string>{"vinicius"};
    List<string> search = lista.FindAll(x => x.Length == 4);
    lista.Remove("vinicius");
    lista.RemoveAll(a => a[0] == "v");

    lista.RemoveAt(1);
```