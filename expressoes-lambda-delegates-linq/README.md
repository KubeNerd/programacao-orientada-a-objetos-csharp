
# Expressões Lambda, Delegates, LINQ e `Comparison<T>` em C#

### Introdução
Em C#, **expressões lambda** e **delegates** são conceitos essenciais para criar código mais limpo e funcional. Elas permitem escrever métodos anônimos de forma concisa, manipular coleções com facilidade através do LINQ, e realizar comparações personalizadas para ordenar objetos. Vamos entender esses conceitos em detalhes, passo a passo.

---

### 1. Expressões Lambda

Uma expressão lambda é uma forma simplificada de escrever métodos anônimos. Ela usa o operador `=>`, que é chamado de "operador lambda". Lambdas são ideais quando você precisa passar uma função como parâmetro para um método ou criar uma função rápida e simples sem declarar um método completo.

#### **Exemplo de uma expressão lambda simples:**
```csharp
Func<int, int> square = x => x * x;
int result = square(5);  // Resultado: 25
```

**Analogia:** Imagine uma expressão lambda como uma calculadora de bolso que você pode programar rapidamente para realizar uma operação específica (como elevar um número ao quadrado). Não é necessário definir um método complexo ou dar um nome a ele; você apenas diz à calculadora para "fazer isso agora".

#### **Sintaxe Geral de uma Lambda:**
```csharp
(parâmetros) => expressão ou bloco de código;
```
**Exemplos:**
```csharp
// Uma lambda que soma dois números:
Func<int, int, int> soma = (a, b) => a + b;
Console.WriteLine(soma(3, 4));  // Resultado: 7

// Uma lambda mais complexa que usa um bloco de código:
Action<string> saudacao = nome =>
{
    Console.WriteLine($"Olá, {nome}!");
};
saudacao("Carlos");  // Resultado: Olá, Carlos!
```

---

### 2. Delegates

**Delegates** são tipos que armazenam referências a métodos, permitindo que métodos sejam passados como parâmetros para outros métodos, armazenados em variáveis e invocados de forma dinâmica. Eles são a base para eventos e callbacks em C#.

**Analogia:** Pense em um delegate como um adaptador universal que permite conectar diferentes tipos de dispositivos (métodos) a uma mesma entrada (variável de delegate). Desde que o método siga a "forma" correta (assinatura), ele pode ser conectado e usado.

#### **Definindo e Usando Delegates:**
```csharp
// Define um delegate que aceita dois inteiros e retorna um inteiro
public delegate int Operacao(int a, int b);

// Um método que pode ser usado com o delegate:
public static int Soma(int a, int b) => a + b;

public static void Main()
{
    Operacao operacao = new Operacao(Soma);
    Console.WriteLine(operacao(3, 4));  // Resultado: 7
}
```

**Uso comum:** Delegates são frequentemente usados para implementar padrões de design como callbacks, onde um método é passado como parâmetro para ser chamado em outro momento.

---

### 3. LINQ (Language-Integrated Query)

**LINQ** é uma linguagem integrada no C# que permite consultar e manipular coleções de dados, sejam listas, arrays, bancos de dados ou até mesmo XML, de uma forma declarativa e legível. As expressões lambda são frequentemente usadas para definir critérios de busca, filtros e transformações.

#### **Exemplo de LINQ com uma lista:**
```csharp
var numeros = new List<int> { 1, 2, 3, 4, 5 };
var numerosPares = numeros.Where(n => n % 2 == 0).ToList();

foreach (var num in numerosPares)
{
    Console.WriteLine(num);  // Resultado: 2, 4
}
```

**Analogia:** Imagine LINQ como um sistema de filtros em uma fábrica de produção. Cada expressão lambda que você usa é como um filtro específico que deixa passar apenas as peças que atendem a certos critérios. No exemplo, o filtro só deixa passar números pares.

**Mais exemplos com LINQ:**
```csharp
// Filtra uma lista de palavras para encontrar as que começam com 'A'
var palavras = new List<string> { "Apple", "Banana", "Apricot", "Cherry" };
var palavrasComA = palavras.Where(p => p.StartsWith("A")).ToList();

// Transforma todos os números em uma lista multiplicando por 10
var numerosMultiplicados = numeros.Select(n => n * 10).ToList();
```

---

### 4. Uso do `Comparison<T>`

O `Comparison<T>` é um delegate que define regras de comparação para ordenar coleções. Ele é muito útil quando você precisa ordenar listas de objetos complexos e deseja criar sua própria lógica de ordenação.

**Analogia:** Imagine que você é um juiz em uma competição de culinária. `Comparison<T>` é como um conjunto de critérios que você usa para decidir qual prato é melhor. Pode ser sabor, apresentação, ou ambos. Você decide a regra!

#### **Exemplo prático com `Comparison<T>`:**
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

        // Usando Comparison<T> com expressão lambda para ordenar por preço crescente
        produtos.Sort((p1, p2) => p1.Preco.CompareTo(p2.Preco));

        // Exibindo os produtos ordenados
        foreach (var produto in produtos)
        {
            Console.WriteLine($"{produto.Nome} - {produto.Preco}");
        }
    }
}
```
**Resultado:**
```
Camiseta - 19.99
Calça - 39.99
Tênis - 89.99
```

---

### Conclusão

- **Expressões lambda** simplificam a definição de métodos e funções anônimas.
- **Delegates** permitem que métodos sejam passados como variáveis e usados de forma dinâmica.
- **LINQ** facilita a manipulação de coleções e integração de consultas em código C#.
- **`Comparison<T>`** permite criar regras personalizadas de ordenação para listas complexas.

