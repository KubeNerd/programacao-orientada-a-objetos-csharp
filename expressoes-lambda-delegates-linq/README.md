# Expressões Lambda, Delegates, LINQ e Comparison em C#

### Introdução
Este exemplo ilustra o uso de **expressões lambda**, **delegates**, **LINQ** e o delegate **Comparison** no C#. Essas ferramentas são essenciais para manipulação e organização de coleções de dados de forma eficiente.

### 1. Expressões Lambda
Expressões lambda são uma maneira concisa de representar métodos anônimos ou funções. Elas são frequentemente usadas em conjunto com LINQ, delegates e ao passar funções como parâmetros.

#### Exemplo de uma expressão lambda simples:
```csharp
Func<int, int> square = x => x * x;
int result = square(5);  // resultado: 25
```

### 2. Delegates
Delegates são tipos que encapsulam métodos e permitem que métodos sejam passados como parâmetros. Eles são usados para implementar callbacks e eventos.

```csharp
public delegate int Operacao(int a, int b);

public class Exemplo
{
    public static int Soma(int a, int b) => a + b;

    public static void Main()
    {
        Operacao operacao = new Operacao(Soma);
        Console.WriteLine(operacao(3, 4));  // resultado: 7
    }
}

```


### 3. LINQ (Language-Integrated Query)
LINQ é uma maneira integrada ao C# de consultar coleções, bancos de dados, XML, entre outros. Ele oferece uma sintaxe poderosa e familiar.

Exemplo de LINQ com uma lista:


```csharp
var numbers = new List<int> { 1, 2, 3, 4, 5 };
var evenNumbers = numbers.Where(n => n % 2 == 0).ToList();

foreach (var num in evenNumbers)
{
    Console.WriteLine(num);  // resultado: 2, 4
}


```

### 4. Uso do Comparison<T>
O Comparison<T> é um delegate que define regras personalizadas de ordenação. Ele encapsula métodos que comparam dois objetos do mesmo tipo e retornam um valor inteiro que indica a ordem relativa.

```csharp
public delegate int Comparison<in T>(T x, T y);

```

O método Sort da classe List<T> pode utilizar um Comparison<T> para ordenar seus elementos. Utilizar expressões lambda torna essa abordagem muito concisa.

Exemplo prático com Comparison<T>:


```csharp
using System;
using System.Collections.Generic;

public class Produto
{
    public string Nome { get; set; }
    public decimal Preco { get; set; }
}

public class Program
{
    public static void Main()
    {
        List<Produto> produtos = new List<Produto>
        {
            new Produto { Nome = "Camiseta", Preco = 19.99m },
            new Produto { Nome = "Calça", Preco = 39.99m },
            new Produto { Nome = "Tênis", Preco = 89.99m }
        };

        // Usando Comparison<T> com expressão lambda
        produtos.Sort((p1, p2) => p1.Preco.CompareTo(p2.Preco));

        // Exibindo os produtos ordenados
        foreach (var produto in produtos)
        {
            Console.WriteLine($"{produto.Nome} - {produto.Preco}");
        }
    }
}

```