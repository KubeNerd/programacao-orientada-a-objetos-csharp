# Conjuntos em C#: Generics, HashSet e SortedSet

Este repositório tem como objetivo fornecer uma explicação clara e concisa sobre dois tipos importantes de conjuntos (collections) em C#: `HashSet` e `SortedSet`. Conjuntos são usados para armazenar uma coleção de elementos únicos e não permitem valores duplicados. Cada implementação tem suas próprias características e casos de uso específicos.

## Índice
- [Conceito Geral](#conceito-geral)
- [HashSet](#hashset)
  - [Características](#características)
  - [Exemplo de Uso](#exemplo-de-uso-hashset)
  - [Vantagens e Desvantagens](#vantagens-e-desvantagens-hashset)
- [SortedSet](#sortedset)
  - [Características](#características-sortedset)
  - [Exemplo de Uso](#exemplo-de-uso-sortedset)
  - [Vantagens e Desvantagens](#vantagens-e-desvantagens-sortedset)
- [Conclusão](#conclusão)

---

## Conceito Geral

Conjuntos em C# fazem parte da biblioteca de coleções e são usados para armazenar elementos que não se repetem. Existem diversas implementações de conjuntos, sendo duas das mais comuns: `HashSet` e `SortedSet`. Ambas garantem que os elementos sejam únicos, mas diferem em como gerenciam a ordem dos elementos e o desempenho.

---

## HashSet

### Características

- **Não permite elementos duplicados**: Como todo conjunto, um `HashSet` impede a inserção de valores duplicados.
- **Não garante ordem**: Os elementos não são mantidos em nenhuma ordem específica.
- **Baseado em hashing**: Internamente, o `HashSet` usa uma tabela de hash, o que permite operações eficientes de inserção, remoção e busca.
- **Tempo constante (O(1))**: Em média, as operações de adição, remoção e verificação de elementos têm complexidade O(1).

### Exemplo de Uso HashSet

```csharp
using System;
using System.Collections.Generic;

class HashSetExample {
    static void Main() {
        HashSet<string> frutas = new HashSet<string>();
        frutas.Add("Maçã");
        frutas.Add("Banana");
        frutas.Add("Laranja");
        frutas.Add("Maçã");  // Elemento duplicado, será ignorado

        foreach (var fruta in frutas) {
            Console.WriteLine(fruta);  // A ordem não é garantida
        }
    }
}
```



## Dicionários (`Dictionary`) em C#

O `Dictionary<TKey, TValue>` em C# é uma coleção que permite armazenar pares chave-valor, onde cada chave única é associada a um valor correspondente. Esse tipo de estrutura de dados é amplamente utilizado em situações onde a busca por valores associados a uma chave deve ser eficiente.

## Características

- **Chave (`TKey`)**: Deve ser única. Um `Dictionary` não permite chaves duplicadas.
- **Valor (`TValue`)**: Pode ser qualquer tipo de dado, desde tipos primitivos até objetos complexos.

O `Dictionary` é baseado em uma **tabela hash**, o que significa que a busca, inserção e remoção de elementos é feita com eficiência O(1) em média.

## Principais Métodos

- `Add(TKey key, TValue value)`: Adiciona um novo par chave-valor ao dicionário. Lança uma exceção se a chave já existir.
- `Remove(TKey key)`: Remove o par associado à chave.
- `ContainsKey(TKey key)`: Verifica se o dicionário contém uma determinada chave.
- `TryGetValue(TKey key, out TValue value)`: Tenta obter o valor associado à chave sem lançar exceção caso a chave não exista.
- `Keys` e `Values`: Retorna coleções das chaves ou valores presentes no dicionário.

## Exemplo Simples

```csharp
using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Dictionary<string, int> ages = new Dictionary<string, int>();

        // Adicionando valores
        ages.Add("Maria", 30);
        ages.Add("João", 25);

        // Acessando valores
        Console.WriteLine("Idade de Maria: " + ages["Maria"]);

        // Atualizando um valor
        ages["Maria"] = 31;

        // Removendo um valor
        ages.Remove("João");

        // Verificando se uma chave existe
        if (ages.ContainsKey("Carlos"))
        {
            Console.WriteLine("Carlos está no dicionário.");
        }
        else
        {
            Console.WriteLine("Carlos não encontrado.");
        }
    }
}

```


# Generics em C#

**Generics** em C# são uma poderosa funcionalidade que permite que você crie classes, métodos e interfaces que funcionem com qualquer tipo de dado, sem perder a segurança de tipo em tempo de compilação. Em vez de definir explicitamente o tipo de dado com o qual você deseja trabalhar, você pode usar parâmetros de tipo.

Aqui está um exemplo básico de uma classe genérica:

```csharp
public class Caixa<T>
{
    private T conteudo;

    public void Adicionar(T item)
    {
        conteudo = item;
    }

    public T Retirar()
    {
        return conteudo;
    }
}
```

Neste exemplo, a classe `Caixa<T>` pode armazenar qualquer tipo de objeto. O `T` é um placeholder para o tipo que será definido quando você criar uma instância da classe:

```csharp
var caixaDeInt = new Caixa<int>();
caixaDeInt.Adicionar(5);
int valor = caixaDeInt.Retirar();

var caixaDeString = new Caixa<string>();
caixaDeString.Adicionar("Olá");
string mensagem = caixaDeString.Retirar();
```

## Restrições em Generics

As restrições são usadas para limitar os tipos de dados que podem ser utilizados como argumentos de tipo em um tipo genérico. Isso permite que você imponha regras sobre quais operações podem ser executadas nesses tipos dentro da classe ou método genérico.

Aqui estão algumas das restrições mais comuns:

1. **`where T : struct`**
   - Esta restrição especifica que o parâmetro de tipo deve ser um tipo de valor (ex: `int`, `bool`, `DateTime`).
   
   ```csharp
   public class ExemploValor<T> where T : struct
   {
       public T Valor { get; set; }
   }
   ```

2. **`where T : class`**
   - Esta restrição especifica que o parâmetro de tipo deve ser uma classe (tipo de referência), excluindo tipos de valor.
   
   ```csharp
   public class ExemploReferencia<T> where T : class
   {
       public T Objeto { get; set; }
   }
   ```

3. **`where T : new()`**
   - Esta restrição especifica que o parâmetro de tipo deve ter um construtor sem parâmetros. Isso permite que você instancie objetos dentro da classe genérica.

   ```csharp
   public class Fabrica<T> where T : new()
   {
       public T CriarInstancia()
       {
           return new T();
       }
   }
   ```

4. **`where T : BaseClass`**
   - Esta restrição garante que o parâmetro de tipo deve ser uma classe que herda (ou é) de uma classe base específica.

   ```csharp
   public class ExemploHeranca<T> where T : Animal
   {
       public void FazerSom(T animal)
       {
           animal.EmitirSom();
       }
   }
   ```

5. **`where T : IInterface`**
   - Esta restrição especifica que o tipo deve implementar uma interface específica.

   ```csharp
   public class ExemploInterface<T> where T : IDisposable
   {
       public void Fechar(T recurso)
       {
           recurso.Dispose();
       }
   }
   ```

## Exemplo Completo com Restrição Múltipla

Você também pode combinar várias restrições ao mesmo tempo. Veja um exemplo com múltiplas restrições:

```csharp
public class Repositorio<T> where T : class, new()
{
    public T CriarInstancia()
    {
        return new T();
    }
}
```

Neste exemplo, `T` deve ser uma classe (`class`) e ter um construtor sem parâmetros (`new()`).

## Considerações

- **Performance:** Generics em C# são altamente otimizados, e o compilador faz um trabalho eficiente em manter a segurança de tipo sem comprometer a performance.
- **Tipos de valor e referência:** Quando usados com tipos de valor, o compilador cria versões específicas para esses tipos (via *boxing* e *unboxing*). Para tipos de referência, ele compartilha a implementação.



# Exemplo de Uso do IComparable<T> com Generics em C#

Este exemplo demonstra como implementar a interface `IComparable<T>` em uma classe genérica no C#. A interface é usada para comparar instâncias de objetos de maneira flexível, permitindo que objetos possam ser classificados com base em seus valores.

## O que é o `IComparable<T>`?

A interface `IComparable<T>` define um método chamado `CompareTo(T other)`, que é utilizado para comparar a instância atual de um objeto com outra instância do mesmo tipo. Ele retorna:
- **0**: se os dois objetos forem iguais.
- **Menor que 0**: se a instância atual for "menor" que a outra instância.
- **Maior que 0**: se a instância atual for "maior" que a outra instância.

Essa interface é amplamente utilizada para ordenação, por exemplo, em métodos como `Array.Sort` e `List<T>.Sort`.

## Implementando `IComparable<T>` com Generics

Ao usar Generics, podemos permitir que uma classe implemente `IComparable<T>` e compare qualquer tipo de objeto, tornando o código mais flexível.

### Exemplo de Implementação

O código a seguir demonstra uma classe genérica `Caixa<T>` que implementa a interface `IComparable<Caixa<T>>`. Nesta implementação, caixas são comparadas com base em um valor numérico armazenado dentro delas.

```csharp
using System;

// Classe genérica Caixa<T> que implementa IComparable<T>
public class Caixa<T> : IComparable<Caixa<T>> where T : IComparable<T>
{
    public T Valor { get; set; }

    // Construtor
    public Caixa(T valor)
    {
        Valor = valor;
    }

    // Implementação de CompareTo
    public int CompareTo(Caixa<T> other)
    {
        if (other == null)
        {
            return 1; // Qualquer objeto é maior que null
        }

        // Usando o método CompareTo de T para comparar os valores
        return Valor.CompareTo(other.Valor);
    }

    public override string ToString()
    {
        return $"Caixa com valor: {Valor}";
    }
}

public class Program
{
    public static void Main()
    {
        // Criando caixas com valores inteiros
        var caixa1 = new Caixa<int>(10);
        var caixa2 = new Caixa<int>(20);
        var caixa3 = new Caixa<int>(15);

        // Adicionando caixas em um array e ordenando
        Caixa<int>[] caixas = { caixa1, caixa2, caixa3 };
        Array.Sort(caixas);

        // Exibindo as caixas ordenadas
        foreach (var caixa in caixas)
        {
            Console.WriteLine(caixa);
        }
    }
}
```

### Explicação do Código

1. **`Caixa<T>`**: Uma classe genérica que armazena um valor do tipo `T`.
2. **`IComparable<Caixa<T>>`**: Implementamos essa interface para permitir que as instâncias de `Caixa<T>` sejam comparadas. A comparação se baseia no valor de `T`.
3. **`where T : IComparable<T>`**: Adicionamos essa restrição genérica para garantir que o tipo `T` suporte a comparação. Isso é importante para garantir que o método `CompareTo` possa ser chamado no valor do tipo `T`.
4. **`CompareTo(Caixa<T> other)`**: O método compara a instância atual com outra instância de `Caixa<T>` usando o valor armazenado, chamando o método `CompareTo` do próprio tipo `T`.
5. **`Array.Sort(caixas)`**: Aqui utilizamos a ordenação do array, que vai usar o método `CompareTo` que implementamos para ordenar as caixas com base no valor.

### Saída Esperada

O programa imprimirá as caixas em ordem crescente com base no valor do tipo `int`:

```
Caixa com valor: 10
Caixa com valor: 15
Caixa com valor: 20
```

### Pontos Críticos

- **Restrições genéricas (`where T : IComparable<T>`)**: Elas garantem que o tipo `T` suporte a interface `IComparable<T>`, pois nem todos os tipos possuem um comportamento de comparação.
- **Manutenção do código**: Com generics, você pode reutilizar essa classe para diferentes tipos de dados (int, string, double, etc.), contanto que eles implementem `IComparable<T>`.

Essa abordagem permite que o código seja flexível e fácil de adaptar a diferentes cenários que precisem de comparação.
