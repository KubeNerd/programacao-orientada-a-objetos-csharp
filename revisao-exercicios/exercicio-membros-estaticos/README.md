
# Guia de Boas Práticas em C# - DollarCalculator

Este guia apresenta boas práticas em C# focadas no uso de entidades, separação de responsabilidades, injeção de dependências, e outras recomendações que ajudam a escrever código mais limpo e sustentável.

## 1. Entidades Devem Representar Dados, Não Comportamentos Complexos

### Conceito
As classes que representam entidades devem conter apenas dados, não lógica complexa. Por exemplo, o cálculo do valor total do dólar não deve estar diretamente dentro de uma entidade como `DollarCalculator`, mas sim em um serviço especializado, como `DollarService`, para garantir que a entidade permaneça simples e focada nos dados.

### Por quê?
Isso segue o princípio da responsabilidade única (SRP - Single Responsibility Principle). O cálculo de valores e do IOF é uma responsabilidade diferente da entidade, que deve apenas armazenar dados como o valor da cotação e a quantidade de dólares.

### Como melhorar
Coloque a lógica de cálculo e regras de negócio em um serviço específico, como `DollarService`, e mantenha `DollarCalculator` simples, contendo apenas os dados.

### Exemplo Ruim:
```csharp
public class DollarCalculator
{
    public double DollarQuote { get; set; }
    public int DollarQuantity { get; set; }

    public double Total() // Errado: lógica de negócio dentro da entidade
    {
        return DollarQuote * DollarQuantity * 1.06; // Incluindo IOF na própria classe
    }
}
```

### Exemplo Melhor:
```csharp
public class DollarCalculator
{
    public double DollarQuote { get; set; }
    public int DollarQuantity { get; set; }
}

public class DollarService
{
    private const double IOF = 6.0;

    public double CalculateTotal(DollarCalculator calculator) // Correto: lógica separada
    {
        double baseValue = calculator.DollarQuote * calculator.DollarQuantity;
        return baseValue + (baseValue * IOF / 100);
    }
}
```

---

## 2. Utilize Injeção de Dependência Sempre Que Possível

### Conceito
Ao invés de instanciar diretamente a lógica de cálculo dentro do código principal, utilize Injeção de Dependência (DI) para obter o serviço que realiza o cálculo.

### Por quê?
Isso promove o desacoplamento e facilita a manutenção do código. Você poderá mudar o serviço de cálculo (por exemplo, uma variação de IOF) sem precisar alterar a classe principal ou outras partes do sistema.

### Como melhorar
Ao invés de criar instâncias diretamente, injete os serviços via construtores ou frameworks de DI.

### Exemplo Ruim:
```csharp
public class Program
{
    static void Main()
    {
        var calculator = new DollarCalculator { DollarQuote = 5.25, DollarQuantity = 100 };
        var total = calculator.Total(); // Errado: lógica dentro da entidade
        Console.WriteLine(total);
    }
}
```

### Exemplo Melhor:
```csharp
public class Program
{
    static void Main()
    {
        var calculator = new DollarCalculator { DollarQuote = 5.25, DollarQuantity = 100 };
        var service = new DollarService();
        var total = service.CalculateTotal(calculator); // Correto: serviço externo realiza o cálculo
        Console.WriteLine(total);
    }
}
```

---

## 3. Evite Códigos “Hardcoded” (Caminhos Fixos e Valores Mágicos)

### Conceito
Valores fixos, como o IOF de 6%, não devem ser "hardcoded" no meio do código. Devemos externalizar esses valores, seja para constantes, variáveis de configuração ou até mesmo para um arquivo externo, como `appsettings`.

### Por quê?
Isso torna o código mais flexível, pois se esses valores mudarem, será mais fácil fazer alterações sem modificar diretamente o código.

### Como melhorar
Defina constantes para valores como IOF ou armazene-os em um arquivo de configuração.

### Exemplo Ruim:
```csharp
public double CalculateTotal(DollarCalculator calculator)
{
    return calculator.DollarQuote * calculator.DollarQuantity * 1.06; // Valor de IOF "hardcoded"
}
```

### Exemplo Melhor:
```csharp
public class DollarService
{
    private const double IOF = 6.0; // Correto: valor definido como constante

    public double CalculateTotal(DollarCalculator calculator)
    {
        double baseValue = calculator.DollarQuote * calculator.DollarQuantity;
        return baseValue + (baseValue * IOF / 100);
    }
}
```

---

## 4. Separe Lógica de Negócio e Lógica de Apresentação

### Conceito
A lógica de apresentação, como exibir resultados no console, deve ser separada da lógica de negócios, que inclui cálculos e manipulação de dados.

### Por quê?
Isso segue o princípio da separação de responsabilidades. Ao isolar a lógica de negócios, o código fica mais reutilizável e modular.

### Como melhorar
A lógica de negócio (como o cálculo do total em reais) deve ficar separada da lógica de exibição (como o `Console.WriteLine`).

### Exemplo Ruim:
```csharp
public class DollarCalculator
{
    public double DollarQuote { get; set; }
    public int DollarQuantity { get; set; }

    public void DisplayTotal()
    {
        Console.WriteLine($"Total: {DollarQuote * DollarQuantity * 1.06}");
    }
}
```

### Exemplo Melhor:
```csharp
public class DollarCalculator
{
    public double DollarQuote { get; set; }
    public int DollarQuantity { get; set; }
}

public class DollarPresenter
{
    public void DisplayTotal(double total)
    {
        Console.WriteLine($"Total: {total}");
    }
}
```

---

## 5. Manipulação de Arquivos Deve Ser Feita com Cuidado

### Conceito
Manipulação de arquivos (leitura/escrita) deve ser feita com o uso correto de estruturas que garantam o fechamento seguro de recursos, como o bloco `using`.

### Por quê?
O uso adequado do `using` garante que os recursos sejam liberados corretamente, mesmo que uma exceção ocorra durante a execução.

### Como melhorar
Sempre utilize `using` para garantir que arquivos e streams sejam fechados corretamente.

### Exemplo Melhor:
```csharp
using (var reader = new StreamReader("caminho/do/arquivo.csv"))
{
    string content = reader.ReadToEnd();
}
```

---

## 6. Boas Práticas de Nomenclatura e Convenções

### Conceito
Seguir convenções de nomenclatura melhora a legibilidade e a manutenção do código.

### Convenções a seguir:
- **Classes**: PascalCase (`DollarCalculator`, `DollarService`).
- **Métodos**: PascalCase (`CalculateTotal`, `DisplayTotal`).
- **Propriedades**: PascalCase (`DollarQuote`, `DollarQuantity`).
- **Variáveis Locais**: camelCase (`totalValue`, `iofRate`).

### Por quê?
Uma nomenclatura clara e consistente facilita a leitura do código, especialmente em projetos maiores e em equipes.

---

## Pensar como um Desenvolvedor C#

- **Foque na Separação de Responsabilidades**: Sempre pergunte: "Essa classe ou método está fazendo mais do que deveria?". Se sim, divida responsabilidades em classes/métodos menores.
  
- **Evite Acoplamento Forte**: Evite que uma parte do código dependa fortemente de outra. Utilize interfaces e Injeção de Dependência para reduzir o acoplamento.

- **Preveja Mudanças**: Pergunte-se: "O que aconteceria se essa parte do código precisasse ser alterada no futuro?". Código flexível facilita manutenções futuras.

- **Mantenha a Simplicidade**: "Simplicidade é o auge da sofisticação." Escreva código fácil de entender e mantenha as soluções simples.
