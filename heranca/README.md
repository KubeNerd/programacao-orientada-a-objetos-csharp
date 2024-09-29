# Herança

- É um tipo de associação que permite que uma classe herde dados e comportamentos de outra.

- Definições

- Vantagens
    - Reuso
    - Polimorfismo

- Sintaxe
    ```csharp
        :(estende)
        base(referencia para superclasse)
    ```
## Pilares da OOP(Programação orientada a objetos)
    - Encapsulamento
    - Herança
    - Polimorfismo


# Classes e métodos selados
Em C#, para evitar que um método seja herdado ou sobrescrito, você pode usar a palavra-chave sealed. Essa palavra-chave impede que classes derivadas sobrescrevam um método que já foi marcado como override.

````csharp public class BaseClass
{
    public virtual void MetodoBase() { }
}

public class ClasseDerivada : BaseClass
{
    public sealed override void MetodoBase()
    {
        // Este método não pode ser sobrescrito por classes derivadas de ClasseDerivada
    }
}

public class OutraClasse : ClasseDerivada
{
    // Tentativa de sobrescrever MetodoBase aqui resultaria em erro de compilação.
}
````


# Sobreposição, palavras virtual, override e base

Sobreposição (ou sobrescrita) refere-se à capacidade de uma classe derivada fornecer sua própria implementação de um método que já foi definido em uma classe base. Esse processo é habilitado pelas palavras-chave virtual, override, e pode incluir o uso de base para reutilizar a implementação original.

**virtual**:

A palavra-chave virtual é usada na definição de um método em uma classe base para indicar que ele pode ser sobrescrito em classes derivadas. Sem o uso de virtual, o método não pode ser sobrescrito.

```csharp
public class BaseClass
{
    public virtual void MetodoBase()
    {
        Console.WriteLine("Método da classe base.");
    }
}
```

**Overrride**:
A palavra-chave override é usada em uma classe derivada para sobrescrever (sobrepor) um método virtual definido na classe base. Isso permite que você altere o comportamento do método para essa classe derivada.


```csharp
public class ClasseDerivada : BaseClass
{
    public override void MetodoBase()
    {
        Console.WriteLine("Método sobrescrito na classe derivada.");
    }
}
```

**base**:

A palavra-chave base é usada em uma classe derivada para chamar o método da classe base que foi sobrescrito. Isso é útil quando você deseja reutilizar a lógica da classe base e, ao mesmo tempo, adicionar uma nova funcionalidade.


### Override na prática

```csharp
public class BaseClass
{
    public virtual void MetodoBase()
    {
        Console.WriteLine("Método original na classe base.");
    }
}

public class ClasseDerivada : BaseClass
{
    public override void MetodoBase()
    {
        base.MetodoBase(); // Chama o método original da classe base
        Console.WriteLine("Método sobrescrito na classe derivada.");
    }
}

public class Program
{
    static void Main()
    {
        ClasseDerivada obj = new ClasseDerivada();
        obj.MetodoBase();
    }
}

```


**virtual**: Permite que um método seja sobrescrito em classes derivadas.
**override**: Sobrescreve a implementação de um método virtual da classe base.
**base**: Invoca o método original da classe base dentro de um método sobrescrito.