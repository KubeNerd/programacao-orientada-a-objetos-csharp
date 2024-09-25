# Plano de Estudo para Entendimento de Classes, Listas e Estruturas em C#



1.  Entenda o Básico de Classes e Objetos
    Objetivo: Compreender como criar classes e instanciar objetos.
    Exemplo: Crie uma classe Produto com Nome e Preço. Crie objetos e imprima seus valores.

2. Aprenda Listas (List<T>)
    Objetivo: Manipular coleções de objetos.
    Exemplo: Crie uma lista de Produto e adicione/remova itens. Itere sobre a lista e mostre os valores.
3. Construtores
    Objetivo: Inicializar objetos corretamente.
    Exemplo: Use um construtor em Produto para inicializar Nome e Preço diretamente ao criar o objeto.

4. Métodos em Classes
    Objetivo: Criar métodos para manipular dados.
    Exemplo: Crie um método SubTotal() na classe OrderItem para multiplicar Quantidade pelo Preço do produto.

5. Enums
    Objetivo: Usar enum para representar estados.
    Exemplo: Crie um enum OrderStatus com estados como PendingPayment, Processing, etc.
    6. Integra Tudo em um Pedido
        Objetivo: Juntar tudo em um projeto simples.
    Exemplo: Crie um sistema de pedido com Cliente, Pedido, OrderItem e calcule o total.
        7. Debug e Correção
    Objetivo: Aprender a depurar e corrigir erros.
        Use o Debugger: Execute passo a passo e veja como os valores mudam.


## 1. Entenda o Básico de Classes e Objetos
**Objetivo**: Compreender como criar classes e instanciar objetos.
- **Exemplo**: Crie uma classe `Produto` com `Nome` e `Preço`. Crie objetos e imprima seus valores.

```csharp
class Produto
{
    public string Nome { get; set; }
    public double Preco { get; set; }

    public Produto(string nome, double preco)
    {
        Nome = nome;
        Preco = preco;
    }
}

// Exemplo de uso
Produto p1 = new Produto("TV", 1500.00);
Console.WriteLine($"{p1.Nome}, {p1.Preco}");
```

## 2. Aprenda Listas (`List<T>`)
**Objetivo**: Manipular coleções de objetos.
- **Exemplo**: Crie uma lista de `Produto` e adicione/remova itens. Itere sobre a lista e mostre os valores.

```csharp
List<Produto> produtos = new List<Produto>();
produtos.Add(new Produto("Mouse", 40.00));
produtos.Add(new Produto("Teclado", 80.00));

foreach (Produto p in produtos)
{
    Console.WriteLine($"{p.Nome}, {p.Preco}");
}
```

## 3. Construtores
**Objetivo**: Inicializar objetos corretamente.
- **Exemplo**: Use um construtor em `Produto` para inicializar `Nome` e `Preço` diretamente ao criar o objeto.

```csharp
Produto p2 = new Produto("Monitor", 600.00);
Console.WriteLine($"{p2.Nome}, {p2.Preco}");
```

## 4. Métodos em Classes
**Objetivo**: Criar métodos para manipular dados.
- **Exemplo**: Crie um método `SubTotal()` na classe `OrderItem` para multiplicar `Quantidade` pelo `Preço` do produto.

```csharp
class OrderItem
{
    public int Quantidade { get; set; }
    public Produto Produto { get; set; }

    public OrderItem(int quantidade, Produto produto)
    {
        Quantidade = quantidade;
        Produto = produto;
    }

    public double SubTotal()
    {
        return Quantidade * Produto.Preco;
    }
}
```

## 5. Enums
**Objetivo**: Usar `enum` para representar estados.
- **Exemplo**: Crie um `enum OrderStatus` com estados como `PendingPayment`, `Processing`, etc.

```csharp
enum OrderStatus
{
    PendingPayment,
    Processing,
    Shipped,
    Delivered
}
```

## 6. Integra Tudo em um Pedido
**Objetivo**: Juntar tudo em um projeto simples.
- **Exemplo**: Crie um sistema de pedido com `Cliente`, `Pedido`, `OrderItem` e calcule o total.

```csharp
class Pedido
{
    public DateTime Momento { get; set; }
    public OrderStatus Status { get; set; }
    public List<OrderItem> Itens { get; set; } = new List<OrderItem>();

    public Pedido(DateTime momento, OrderStatus status)
    {
        Momento = momento;
        Status = status;
    }

    public void AddItem(OrderItem item)
    {
        Itens.Add(item);
    }

    public double Total()
    {
        double total = 0;
        foreach (OrderItem item in Itens)
        {
            total += item.SubTotal();
        }
        return total;
    }
}
```

## 7. Debug e Correção
**Objetivo**: Aprender a depurar e corrigir erros.
- **Use o Debugger**: Execute passo a passo e veja como os valores mudam. Adicione breakpoints em áreas chave do código.

```csharp
// Exemplo de execução
Pedido pedido = new Pedido(DateTime.Now, OrderStatus.Processing);
pedido.AddItem(new OrderItem(2, new Produto("Cadeira", 350.00)));
pedido.AddItem(new OrderItem(1, new Produto("Mesa", 700.00)));

Console.WriteLine($"Total do pedido: {pedido.Total()}");
```

---

Este plano de estudo abrange os conceitos essenciais para o entendimento de classes, listas, construtores, métodos, enums, e como juntá-los em um sistema simples de pedidos. Além disso, a importância da depuração para encontrar e resolver erros de forma eficiente é destacada.
