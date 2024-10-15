# Conjuntos em C#: HashSet e SortedSet

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
