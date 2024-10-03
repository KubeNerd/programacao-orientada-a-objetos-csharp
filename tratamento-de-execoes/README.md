# Exceções

- Uma exceção é qualquer condição de erro ou comportamente inesperado encontrado por uma  programa em execução.


-  No .Net, uma execçõa é um objeto herdado da Classe System.Exception

- QUando lançada, uma exceção é propagada na pilha de chamadas de métodos em execução, até que seja capturada(tratada) ou o programa seja encerrado.


## Sintaxe

```csharp
try {

}
catch(ExceptionType e) {

} 
catch(ExceptionType e) {

} 

```


## Pratica de código

```csharp
using System;

namespace Excecoes
{
  class Program
  {
    static void Main(string[] args)
    {
      try
      {
        int n1 = int.Parse(Console.ReadLine());
        int n2 = int.Parse(Console.ReadLine());

        int result = n1 / n2;
        Console.WriteLine(result);
      } 
      catch (Exception e) 
      {
        Console.WriteLIne("Error!", e.Message);
      }   

      catch (DivideByZeroException) 
      {
        Console.WriteLine("Division of {0} by zero is not allowed.");
      }   
    }
  }
}
```
### Bloco Try e catch
- O bloco try contém o código que pode potencialmente gerar uma exceção durante sua execução. Se uma exceção ocorrer, ela será lançada e imediatamente direcionada para o bloco catch, que contém a lógica de tratamento de erros. O objetivo é capturar o erro e tomar medidas apropriadas, como exibir uma mensagem de erro ou implementar uma estratégia de recuperação, sem interromper a execução do programa.

- Exemplo clássico: acessando um índice fora dos limites de um array ou tentando abrir um arquivo que não existe, o bloco catch lidará com o erro e permitirá que o código continue a execução de forma controlada.

```csharp
try
{
  int[] myNumbers = {1, 2, 3};
  Console.WriteLine(myNumbers[10]);
}
catch (Exception e)
{
  Console.WriteLine("Something went wrong.");
}

```



## Bloco Finaly
- É um bloco que contém código a ser executado independentemente de ter ocorrido ou não uma execução.


- Exemplo clássico fechar uma rquivo ou conexão de banco de dados ao final do processamento.


```csharp
try
{
  int[] myNumbers = {1, 2, 3};
  Console.WriteLine(myNumbers[10]);
}
catch (Exception e)
{
  Console.WriteLine("Something went wrong.");
}
finally
{
  Console.WriteLine("The 'try catch' is finished.");
}


```