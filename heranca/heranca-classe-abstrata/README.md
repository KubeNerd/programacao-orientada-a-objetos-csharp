
# Classes e Métodos Abstratos

## Por que usar classes e métodos abstratos?

**Definição de Contrato**: Uma classe abstrata permite definir um contrato para as classes derivadas. Isso significa que as subclasses devem implementar certos métodos, garantindo que todas sigam uma estrutura comum.

**Design Baseado em Herança**: Útil quando você deseja criar um design que possa ser estendido e que force as subclasses a implementar certos comportamentos.

**Reuso de Código**: Você pode fornecer implementações padrão para métodos comuns na classe abstrata, enquanto permite que as subclasses personalizem comportamentos específicos.

## Quando usar classes e métodos abstratos?

### Cenário 1: 
Quando você quer definir uma base comum para um conjunto de classes que compartilham algumas funcionalidades, mas possuem comportamentos específicos que precisam ser implementados individualmente.

**Exemplo**: Imagine uma classe abstrata `Animal` com um método abstrato `EmitirSom()`. Cada subclasse, como `Cachorro` e `Gato`, implementaria esse método de forma diferente.

### Cenário 2: 
Quando você deseja garantir que todas as subclasses implementem métodos críticos, mas ainda oferecer alguma funcionalidade padrão.

**Exemplo**: Um sistema de pagamento poderia ter uma classe abstrata `Pagamento` que define métodos abstratos `ProcessarPagamento()` e `CancelarPagamento()`, enquanto fornece uma implementação comum para `ValidarTransacao()`.

## Exemplo de Código em C#

```csharp
abstract class Animal
{
    public abstract void EmitirSom(); // Método abstrato (sem implementação)

    public void Dormir() // Método comum
    {
        Console.WriteLine("O animal está dormindo");
    }
}

class Cachorro : Animal
{
    public override void EmitirSom()
    {
        Console.WriteLine("O cachorro late");
    }
}

class Gato : Animal
{
    public override void EmitirSom()
    {
        Console.WriteLine("O gato mia");
    }
}
```

**Classe Abstrata**: Use para criar uma estrutura que outras classes possam herdar, forçando-as a implementar certos comportamentos, e permitindo que compartilhem implementações comuns.