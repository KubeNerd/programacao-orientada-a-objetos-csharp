
# Classes e Métodos Estáticos

## Por que usar classes e métodos estáticos?

### Funções Utilitárias
Métodos estáticos são ideais para funções que não precisam manter estado (ou seja, não utilizam variáveis de instância). Eles atuam como funções utilitárias ou helpers, independentes de uma instância específica da classe.

### Eficiência e Simplicidade
Evitar a necessidade de criar uma instância de um objeto para usar métodos que podem ser globais e acessíveis a partir de qualquer lugar torna o código mais eficiente e simples.

## Quando usar classes e métodos estáticos?

### Cenário 1: Operações Simples
Quando uma função realiza uma operação simples que não depende do estado de uma classe.
**Exemplo:** Métodos matemáticos como `Math.Sqrt` ou `Math.Pow`, que apenas recebem parâmetros e retornam resultados sem manipular estado interno.

### Cenário 2: Agrupamento de Funcionalidades
Quando é necessário agrupar funcionalidades relacionadas que não necessitam de estado.
**Exemplo:** Uma classe estática `Logger` para registrar mensagens de log em diferentes partes da aplicação.

### Cenário 3: Configuração Global
Quando uma configuração precisa ser acessível globalmente pela aplicação.
**Exemplo:** Uma classe estática `Config` que armazena valores de configuração utilizados em toda a aplicação.

## Exemplo em C#

```csharp
static class MathUtil
{
    public static int Somar(int a, int b)
    {
        return a + b;
    }

    public static int Multiplicar(int a, int b)
    {
        return a * b;
    }
}

// Uso
int resultado = MathUtil.Somar(5, 3); // Resultado: 8
```

## Pontos Críticos

- **Classes e Métodos Abstratos**: Devem ser usados quando a arquitetura da aplicação requer uma estrutura flexível, que será estendida e personalizada. As classes derivadas devem seguir um contrato definido, e a falta de implementação completa em uma classe abstrata ajuda a reforçar isso.
- **Classes e Métodos Estáticos**: São melhores quando não há necessidade de estado. Contudo, o uso excessivo de métodos estáticos pode levar a problemas de manutenção, como acoplamento alto e dificuldades para testes unitários (métodos estáticos são mais complicados de mockar).


**Classe Estática**: Use para métodos que não dependem do estado de instância e servem como utilitários ou funcionalidades globais acessíveis de qualquer lugar da aplicação.