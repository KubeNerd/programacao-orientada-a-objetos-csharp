# Extension Methods em C#

Extension Methods permitem estender a funcionalidade de tipos existentes (como classes, interfaces ou structs) sem a necessidade de modificar o código fonte original ou utilizar herança.

## Como Criar um Extension Method?

### Passos:
1. Criar uma **classe estática**.
2. Criar um **método estático** dentro da classe.
3. O **primeiro parâmetro** do método deve ter o prefixo `this`, seguido do tipo que se deseja estender.

### Exemplo:

No exemplo a seguir, criaremos um método de extensão para o tipo `string`, chamado `WordCount()`, que contará o número de palavras em uma string.

```csharp
public static class StringExtensions
{
    // Método de extensão para o tipo string
    public static int WordCount(this string str)
    {
        if (string.IsNullOrWhiteSpace(str))
            return 0;

        // Divide a string por espaços e conta as palavras
        return str.Split(' ').Length;
    }
}

```

### Considerações Importantes:

**Escopo de Visibilidade**: O método de extensão só estará disponível se o namespace da classe que contém o método estiver incluído no arquivo com using.

**Conflito de Nomes**: Se a classe original já contiver um método com o mesmo nome e assinatura, o método de instância terá prioridade sobre o método de extensão.

**Vantagens**:
Permite adicionar funcionalidades sem alterar a classe original.
Mantém o código limpo e organizado.
Extende funcionalidades de tipos de terceiros ou de bibliotecas que não podem ser modificadas.