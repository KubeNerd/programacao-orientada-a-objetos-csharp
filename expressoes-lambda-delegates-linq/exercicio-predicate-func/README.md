
# Predicate e Action no C#

O **Predicate** e o **Action** são dois tipos de delegados no C# que permitem passar comportamentos (funções ou métodos) como parâmetros para outros métodos. Ambos são usados para tornar o código mais flexível e reutilizável, mas possuem diferenças claras no que fazem e em como são usados.

## 1. Predicate

Como mencionado anteriormente, um `Predicate<T>` é um delegado que representa um método que recebe um parâmetro de um tipo específico (`T`) e retorna um valor booleano (`true` ou `false`). Ele é usado principalmente para fazer verificações ou filtros.

**Estrutura:**
```csharps
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

## Func no C#

O **`Func`** é um tipo de delegado genérico no C# que representa um método que pode receber parâmetros de entrada e sempre retorna um valor. Ele é um dos delegados mais versáteis e é amplamente utilizado quando você precisa executar operações que retornam resultados.

### Estrutura do `Func`

O `Func` pode aceitar de **zero a dezesseis parâmetros de entrada** e deve sempre **retornar um valor**. A assinatura geral do `Func` é assim:

```csharp
public delegate TResult Func<in T1, in T2, ..., out TResult>(T1 arg1, T2 arg2, ...);
```

- Os parâmetros `T1`, `T2`, etc., são tipos de entrada, e `TResult` é o tipo de retorno.
- Se o `Func` não tiver parâmetros de entrada, você define apenas o tipo de retorno (`Func<TResult>`).

### Exemplos de Uso

#### 1. `Func` com um Parâmetro de Entrada e um Resultado

Vamos começar com um exemplo simples. Suponha que você queira calcular o quadrado de um número:

```csharp
Func<int, int> square = x => x * x;

int result = square(5); // Resultado será 25
Console.WriteLine(result);
```

Neste exemplo:
- `Func<int, int>` indica que o `Func` recebe um `int` como entrada e retorna um `int`.
- `x => x * x` é uma expressão lambda que define o comportamento do `Func`.

#### 2. `Func` com Múltiplos Parâmetros

Se você quiser somar dois números, pode usar um `Func` que recebe dois parâmetros de entrada:

```csharp
Func<int, int, int> add = (a, b) => a + b;

int sum = add(3, 4); // Resultado será 7
Console.WriteLine(sum);
```

Neste exemplo:
- `Func<int, int, int>` significa que o `Func` recebe dois `int`s como entrada e retorna um `int`.
- `(a, b) => a + b` é a expressão lambda que soma os dois valores.

#### 3. `Func` Sem Parâmetros de Entrada (Apenas Retorno)

Você também pode usar um `Func` sem parâmetros de entrada. Por exemplo:

```csharp
Func<string> getMessage = () => "Hello, World!";

string message = getMessage(); // Resultado será "Hello, World!"
Console.WriteLine(message);
```

Aqui, `Func<string>` define um `Func` que não recebe nenhum parâmetro, mas retorna uma `string`.

### Diferença entre Func, Action e Predicate

| **Característica**     | **Func**                             | **Action**                             | **Predicate**                          |
|------------------------|-------------------------------------|---------------------------------------|----------------------------------------|
| **Retorno**            | Retorna um valor (`TResult`)        | `void` (não retorna nada)             | `bool` (`true` ou `false`)             |
| **Parâmetros de Entrada**| Zero a dezesseis                   | Zero a dezesseis                      | Um único parâmetro (`T`)               |
| **Uso Comum**          | Operações que precisam de retorno   | Operações que não precisam de retorno | Verificações e filtros                |
| **Exemplo de Uso**     | Transformações (`Select` em LINQ)   | Executar ações (`ForEach`)            | Filtragem e verificação (`RemoveAll`)  |

### Quando Usar `Func`

- Use **`Func`** quando precisar de um método que **retorne um valor**, e esse método puder ser passado como argumento para outros métodos.
- É ideal para transformar ou calcular valores, como operações matemáticas, formatação de texto, e filtragem de dados em conjunto com métodos LINQ como `Select` e `Where`.

### Exemplo Avançado: Usando `Func` no LINQ

Imagine que você tenha uma lista de preços e deseja aplicar um desconto de 10% a cada um deles:

```csharp
List<double> prices = new List<double> { 100.0, 200.0, 300.0 };

Func<double, double> applyDiscount = price => price * 0.9;

List<double> discountedPrices = prices.Select(applyDiscount).ToList();

discountedPrices.ForEach(p => Console.WriteLine(p));
```

Neste exemplo:
- `Func<double, double>` é usado para definir uma função que aplica um desconto de 10% a cada preço.
- `Select` usa esse `Func` para transformar cada item na lista `prices`.

### Conclusão

O **`Func`** é um delegado poderoso e versátil em C#. Ele é utilizado quando você precisa definir métodos que aceitam parâmetros de entrada e retornam valores. Com ele, é possível escrever código mais modular e flexível, separando a lógica de cálculo ou transformação em métodos reutilizáveis que podem ser passados como argumentos para outros métodos, especialmente no contexto de LINQ e outras APIs funcionais.

Com o uso correto de `Func`, `Action`, e `Predicate`, você pode criar programas mais limpos, legíveis e fáceis de manter.
