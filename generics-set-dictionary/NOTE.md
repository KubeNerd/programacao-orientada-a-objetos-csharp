
# Conjuntos em C#: Generics, HashSet e SortedSet

Este repositório tem como objetivo fornecer uma explicação clara e concisa sobre dois tipos importantes de conjuntos (collections) em C#: `HashSet` e `SortedSet`. Conjuntos são usados para armazenar uma coleção de elementos únicos e não permitem valores duplicados. Cada implementação tem suas próprias características e casos de uso específicos.

## Índice
- [Conceito Geral](#conceito-geral)
- [HashSet](#hashset)
  - [Características](#características-do-hashset)
  - [Exemplo de Uso](#exemplo-de-uso-hashset)
  - [Vantagens e Desvantagens](#vantagens-e-desvantagens-hashset)
- [SortedSet](#sortedset)
  - [Características](#características-do-sortedset)
  - [Exemplo de Uso](#exemplo-de-uso-sortedset)
  - [Vantagens e Desvantagens](#vantagens-e-desvantagens-sortedset)
- [GetHashCode e Equals](#gethashcode-e-equals)
  - [Explicação Detalhada](#explicação-detalhada)
  - [Exemplo de Implementação](#exemplo-de-implementação)
- [Conclusão](#conclusão)

---

## Conceito Geral

Conjuntos em C# fazem parte da biblioteca de coleções e são usados para armazenar elementos que não se repetem. Existem diversas implementações de conjuntos, sendo duas das mais comuns: `HashSet` e `SortedSet`. Ambas garantem que os elementos sejam únicos, mas diferem em como gerenciam a ordem dos elementos e o desempenho.

---

## HashSet

### Características do HashSet

- **Não permite elementos duplicados**: Um `HashSet` impede a inserção de valores duplicados.
- **Não garante ordem**: Os elementos não são mantidos em nenhuma ordem específica.
- **Baseado em hashing**: Internamente, o `HashSet` usa uma tabela de hash, o que permite operações eficientes de inserção, remoção e busca.
- **Complexidade O(1)**: Em média, as operações de adição, remoção e verificação de elementos têm complexidade O(1), o que garante um desempenho constante.

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

### Vantagens e Desvantagens HashSet

**Vantagens:**
- Operações rápidas, com complexidade O(1) em média.
- Fácil de usar para garantir a unicidade dos elementos.

**Desvantagens:**
- Não garante a ordem dos elementos.
- Pode consumir mais memória que outros tipos de coleções devido à tabela de hash interna.

---

## SortedSet

### Características do SortedSet

- **Não permite elementos duplicados**: Semelhante ao `HashSet`, o `SortedSet` impede duplicações.
- **Mantém os elementos ordenados**: O `SortedSet` garante que os elementos sejam mantidos em ordem crescente, com base em sua implementação de comparação.
- **Complexidade O(log n)**: A inserção, remoção e busca são um pouco mais lentas que no `HashSet`, com complexidade O(log n), pois os elementos precisam ser mantidos ordenados.

### Exemplo de Uso SortedSet

```csharp
using System;
using System.Collections.Generic;

class SortedSetExample {
    static void Main() {
        SortedSet<int> numeros = new SortedSet<int>() { 5, 2, 9, 1 };

        foreach (var numero in numeros) {
            Console.WriteLine(numero);  // Elementos serão exibidos em ordem crescente
        }
    }
}
```

### Vantagens e Desvantagens SortedSet

**Vantagens:**
- Mantém os elementos sempre ordenados.
- Útil quando é necessário garantir a ordenação sem precisar ordenar manualmente.

**Desvantagens:**
- Desempenho ligeiramente inferior ao `HashSet` em termos de inserção e busca, devido à necessidade de manter a ordenação dos elementos.

---

## GetHashCode e Equals

### Explicação Detalhada

Os métodos `GetHashCode` e `Equals` são essenciais para garantir o comportamento correto de coleções baseadas em hash, como `HashSet` e `Dictionary`. Aqui estão as principais funções de ambos os métodos:

#### `Equals`
Este método é usado para comparar se dois objetos são considerados iguais. O comportamento padrão compara referências de objeto, ou seja, se dois objetos são a mesma instância. No entanto, você pode sobrescrevê-lo para definir a igualdade baseada nos valores dos atributos do objeto.

#### `GetHashCode`
O método `GetHashCode` retorna um valor numérico que representa o objeto. Ele é usado em coleções baseadas em hash para localizar rapidamente os elementos. Se dois objetos forem considerados iguais (com `Equals` retornando `true`), eles devem ter o mesmo código de hash retornado por `GetHashCode`.

### Exemplo de Implementação

Aqui está uma implementação correta de `Equals` e `GetHashCode` para uma classe `Pessoa`:

```csharp
public class Pessoa
{
    public string Nome { get; set; }
    public int Idade { get; set; }

    public override bool Equals(object obj)
    {
        if (obj == null || this.GetType() != obj.GetType())
            return false;

        Pessoa outra = (Pessoa)obj;
        return this.Nome == outra.Nome && this.Idade == outra.Idade;
    }

    public override int GetHashCode()
    {
        // Combina os hash codes do nome e idade para gerar um hash único
        return Nome.GetHashCode() ^ Idade.GetHashCode();
    }
}
```

#### Por que são importantes?
- **Equals**: Define como objetos serão comparados para verificar igualdade.
- **GetHashCode**: Garante que objetos iguais tenham o mesmo código de hash, permitindo uma busca eficiente em coleções como `HashSet` e `Dictionary`.
- **Consistência**: Se `Equals` retorna `true` para dois objetos, eles **devem** ter o mesmo valor de `GetHashCode`. Caso contrário, coleções baseadas em hash podem funcionar de forma incorreta.

---

## Conclusão

Neste documento, vimos como os conjuntos `HashSet` e `SortedSet` são usados em C#, incluindo suas características, exemplos de uso e como implementá-los corretamente. Também exploramos os métodos `GetHashCode` e `Equals`, que são fundamentais para garantir o funcionamento correto de coleções baseadas em hash. Agora você tem uma base sólida para escolher e implementar a estrutura de coleção adequada em seus projetos.

---

