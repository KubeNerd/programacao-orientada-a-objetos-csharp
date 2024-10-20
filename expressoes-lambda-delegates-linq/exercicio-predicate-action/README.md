
# Predicate e Action no C#

O **Predicate** e o **Action** são dois tipos de delegados no C# que permitem passar comportamentos (funções ou métodos) como parâmetros para outros métodos. Ambos são usados para tornar o código mais flexível e reutilizável, mas possuem diferenças claras no que fazem e em como são usados.

## 1. Predicate

Como mencionado anteriormente, um `Predicate<T>` é um delegado que representa um método que recebe um parâmetro de um tipo específico (`T`) e retorna um valor booleano (`true` ou `false`). Ele é usado principalmente para fazer verificações ou filtros.

**Estrutura:**
```csharp
public delegate bool Predicate<T>(T obj);
```

**Exemplo:**

No seu código anterior, foi utilizado um `Predicate` com uma expressão lambda:

```csharp
products.RemoveAll(a => a.Price >= 10.00);
```

Aqui, `a => a.Price >= 10.00` é um `Predicate<Product>` que define um critério para remover elementos da lista. Se o `Predicate` retornar `true`, o item é removido.

## 2. Action

O **Action** é outro tipo de delegado, mas ao contrário do `Predicate`, ele não retorna um valor. Um `Action` representa um método que executa uma operação, mas sem produzir um resultado (ele retorna `void`).

**Estrutura:**

Um `Action` pode aceitar de zero a dezesseis parâmetros de entrada e sempre retorna `void`.

**Exemplo de declaração de um Action com um parâmetro:**

```csharp
public delegate void Action<T>(T obj);
```

### Exemplos de Uso:

#### 2.1. Usando Action com um Método

Suponha que você queira imprimir o nome de cada produto na lista:

```csharp
List<Product> products = new List<Product>();

products.Add(new Product("TV", 900.00));
products.Add(new Product("Mouse", 50.00));
products.Add(new Product("Tablet", 350.00));
products.Add(new Product("HD Case", 80.90));

Action<Product> printProduct = p => Console.WriteLine(p.Name);

// Usando o Action em cada produto
products.ForEach(printProduct);
```

Neste exemplo, `printProduct` é um `Action<Product>` que recebe um objeto `Product` e imprime o nome dele. O método `ForEach` da lista aplica o `Action` para cada elemento da lista.

#### 2.2. Usando Action Diretamente em uma Expressão Lambda

Você também pode passar diretamente uma expressão lambda como `Action`:

```csharp
products.ForEach(p => Console.WriteLine(p.Name));
```

## Comparação entre Predicate e Action:

| **Característica**       | **Predicate<T>**                        | **Action<T>**                            |
|--------------------------|-----------------------------------------|------------------------------------------|
| **Retorno**              | `bool` (`true` ou `false`)              | `void` (não retorna nada)                |
| **Uso Comum**            | Verificações, filtros, remoções         | Executar operações (ex: imprimir, salvar)|
| **Parâmetros de Entrada**| Um único parâmetro do tipo `T`          | De zero a dezesseis parâmetros           |
| **Exemplo de Uso**       | `RemoveAll`, `Find`, `Exists`           | `ForEach`, `List.Sort`, `Array.ForEach`  |

## Conclusão

- **Predicate** é ideal para quando você quer testar uma condição e precisa de um resultado booleano.
- **Action** é perfeito para realizar uma operação que não precisa retornar um resultado (ex: imprimir, salvar, logar).
