# Guia de Boas Práticas em C# - Auto Orientação

### 1. Entidades Devem Representar Dados, Não Comportamentos Complexos

**Conceito**: As classes em Entities (entidades) devem representar apenas os dados e as características desses dados. Por exemplo, uma classe Product deve conter propriedades como Name, Price, e Quantity. 

Métodos que modificam ou calculam dados complexos (como calcular o valor total) devem ficar em serviços, e não nas entidades.

**Por quê?**: 

Isso segue o princípio da responsabilidade única (SRP - Single Responsibility Principle). 

Cada classe deve ter uma responsabilidade única e clara. Se você começar a adicionar lógica de cálculo nas entidades, isso cria um acoplamento desnecessário e torna a entidade responsável por mais do que apenas armazenar dados.

### Como melhorar:

Coloque a lógica de cálculos e regras de negócio em serviços (por exemplo, ServiceCalculate) e mantenha as entidades simples.

A entidade pode ter métodos simples relacionados aos dados que ela contém, mas para cálculos complexos e lógica de negócio, sempre use um serviço especializado.

**Exemplo Ruim**:

```csharp
public class Product
{
    public double Price { get; set; }
    public int Quantity { get; set; }

    public double CalculateTotal() // Errado: lógica de negócio dentro da entidade
    {
        return Price * Quantity;
    }
}

```
**Exemplo Melhor**:

```csharp
public class Product
{
    public double Price { get; set; }
    public int Quantity { get; set; }
}

public class ServiceCalculate
{
    public double CalculateTotal(Product product) // Correto: lógica de cálculo separada em um serviço
    {
        return product.Price * product.Quantity;
    }
}
```

#### 2. Utilize Injeção de Dependência Sempre Que Possível

**Conceito**: Em vez de instanciar diretamente dependências dentro das suas classes, como serviços ou repositórios, use a injeção de dependência (DI). Isso mantém seu código mais flexível, permitindo que você altere as implementações facilmente (ex. usar um serviço diferente em um teste).

**Por quê?**: DI promove o desacoplamento. Seu código fica menos dependente de implementações específicas, e mais fácil de manter e testar. Se você quiser mudar a lógica de cálculo no futuro, basta alterar o serviço injetado, sem precisar alterar a entidade ou outras partes do sistema.

**Como melhorar**:

Em vez de criar serviços dentro das entidades, injete-os via construtor.
Quando possível, programe contra interfaces, e não implementações concretas.


**Exemplo Ruim**:

```csharp
public class Product
{
    private ServiceCalculate _serviceCalculate = new ServiceCalculate(); // Errado: instanciando diretamente

    public double CalculateTotal()
    {
        return _serviceCalculate.CalculateTotal(this);
    }
}

```
**Exemplo Melhor**:

```csharp
public class Product
{
    private readonly IServiceCalculate _serviceCalculate;

    public Product(IServiceCalculate serviceCalculate) // Correto: Injeção de dependência via construtor
    {
        _serviceCalculate = serviceCalculate;
    }

    public double CalculateTotal()
    {
        return _serviceCalculate.CalculateTotal(this);
    }
}

```
#### 3. Evite Códigos “Hardcoded” (Caminhos Fixos e Valores Mágicos)

**Conceito**: Nunca "codifique" valores fixos diretamente no código, como caminhos de arquivos ou strings repetidas. Utilize variáveis, constantes, ou configurações externas para esses valores.

**Por quê?**: Isso torna o código mais portável, fácil de configurar, e menos propenso a erros. Se você precisar alterar o caminho de um arquivo ou algum valor específico, você só precisará alterar o valor uma vez, e ele será aplicado em todo o sistema.

**Como melhorar**:

Use variáveis de ambiente, arquivos de configuração (como appsettings.json), ou constantes.

**Exemplo Ruim**:

csharp
string pathSourceContent = @"C:\Users\Usuario\Documents\produtos.csv"; // Caminho "hardcoded"
**Exemplo Melhor**:

csharp
string currentDirectory = Directory.GetCurrentDirectory();
string pathSourceContent = Path.Combine(currentDirectory, "produtos.csv");
### 4. Separe Lógica de Negócio e Lógica de Apresentação
**Conceito**: A lógica de negócios (cálculos, validações, manipulação de dados) deve ser separada da lógica de apresentação (exibir no console, criar arquivos de saída, etc.).

**Por quê?**: Isso segue o princípio de separação de preocupações. Ao isolar a lógica de negócios, você garante que ela possa ser reutilizada em diferentes contextos (ex.: linha de comando, interface gráfica, API) sem precisar duplicar ou modificar código.

**Como melhorar**:

Crie classes de serviços ou regras de negócios e mantenha o código de apresentação (como Console.WriteLine()) separado.
**Exemplo Ruim**:
```csharp
public class Product
{
    public double Price { get; set; }
    public int Quantity { get; set; }

    public void DisplayTotal()
    {
        Console.WriteLine("Total: " + (Price * Quantity));
    }
}
```

**Exemplo Melhor**:

```csharp
public class Product
{
    public double Price { get; set; }
    public int Quantity { get; set; }
}

public class ProductPresenter
{
    public void DisplayTotal(Product product)
    {
        Console.WriteLine("Total: " + (product.Price * product.Quantity));
    }
}
```


#### 5. Manipulação de Arquivos Deve Ser Feita com Cuidado
**Conceito**: Manipulação de arquivos (como leitura e escrita) deve ser feita usando estruturas apropriadas para garantir que o arquivo seja fechado corretamente, mesmo em caso de erros. O uso do bloco using é essencial.

**Por quê?**: Garantir que recursos externos (como arquivos) sejam gerenciados corretamente evita vazamentos de memória e problemas de acesso a arquivos que possam estar sendo usados por outros processos.

**Como melhorar**:

Sempre use o bloco using ao trabalhar com arquivos para garantir que eles sejam fechados automaticamente após o uso.

**Exemplo Melhor**:

```csharp
using (var sr = new StreamReader("produtos.csv"))
{
    string content = sr.ReadToEnd();
}

```

### 6. Boas Práticas de Nomenclatura e Convenções
**Conceito**: Nomes claros e descritivos ajudam na leitura e manutenção do código. 

### Siga as convenções de nomenclatura do C#:

**Classes**: PascalCase (Product, ServiceCalculate).<br/>
**Métodos**: PascalCase (CalculateTotal, GetTotalAmount).<br/>
**Propriedades**: PascalCase (Name, Price).<br/>
**Variáveis Locais**: camelCase (productName, totalPrice).<br/>

**Por quê?**: Usar uma nomenclatura consistente e clara melhora a legibilidade e facilita o trabalho em equipe.<br/>


## Pensar como um Desenvolvedor C#

**Foque na Separação de Responsabilidades**: Sempre pergunte: "Qual a responsabilidade dessa classe/método?" Se uma classe ou método tiver muitas responsabilidades, é hora de dividi-los.<br/>

**Evite Acoplamento Forte**: Se uma parte do código depende fortemente de outra, isso pode ser um sinal de acoplamento. Tente usar abstrações (interfaces) e injeção de dependência para reduzir isso.<br/>

**Preveja Mudanças**: 
-  Pergunte-se: "E se eu precisar mudar essa parte do código no futuro?" Escrever código flexível desde o início economiza trabalho mais tarde.<br/>

**Mantenha a Simplicidade**: "Simples é melhor que complexo." Escreva código fácil de entender. Se você precisar explicar muito, talvez o código esteja complicado demais.