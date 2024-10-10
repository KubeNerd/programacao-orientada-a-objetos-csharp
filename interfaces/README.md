# Introdução as Interfaces

As interfaces são contratos que definem um conjunto de métodos, propriedades, eventos ou indexadores que uma classe ou struct deve implementar. Elas não contêm implementação, apenas as assinaturas dos membros.

A ideia principal é garantir que diferentes classes possam implementar esses métodos de maneira específica, mas sempre seguindo o mesmo contrato definido pela interface. Isso facilita a padronização e o uso do polimorfismo, permitindo que classes diferentes sejam tratadas de maneira uniforme, desde que implementem a mesma interface.


**Exemplo:**

```csharp
public interface IAnimal
{
    void Comer();
    void Dormir();
}

public class Cachorro : IAnimal
{
    public void Comer() => Console.WriteLine("O cachorro está comendo.");
    public void Dormir() => Console.WriteLine("O cachorro está dormindo.");
}

public class Gato : IAnimal
{
    public void Comer() => Console.WriteLine("O gato está comendo.");
    public void Dormir() => Console.WriteLine("O gato está dormindo.");
}

```