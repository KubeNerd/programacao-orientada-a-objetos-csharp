# Conversão de string para enum em C#

Quando você quiser converter uma string para uma enumeração, a forma mais comum é assim:

```csharp
OrderStatus os = Enum.Parse<OrderStatus>("Delivered");
```

Porém, dependendo da versão do compilador, isso pode causar problemas. Se der erro, tenta esse jeito:

```csharp
OrderStatus os = (OrderStatus)Enum.Parse(typeof(OrderStatus), "Delivered");
```

E, se ainda não funcionar, uma terceira opção é usar o TryParse, que é mais seguro:

```csharp
OrderStatus os; 
Enum.TryParse("Delivered", out os);
```