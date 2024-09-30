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
### Bloco catch

```csharp


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