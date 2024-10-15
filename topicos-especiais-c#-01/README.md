### VAR

```csharp
namespace Course {
    class Program {
        static void Main(strings[] args){

            var x = 10;
            var y = 20.0;
            var z =  "Maria";

        }
    }
}

```

## Switch Case

```csharp
using System;

public class Dia
{
    public static void Main(string[] args)
    {
        int x = int.Parse(Console.ReadLine());
        string day;
        
        if(x == 1){
           day = "Sunday";
        } else if(x == 2) {
            day = "Monday";
        } else if (x == 3) {
            day = "Tuesday";
        } else if (x == 4) {
            day = "Wednesday";
        } else if (x == 5) {
            day = "Saturday";
        } else {
            day = "Inválid value";
        }
        
        Console.WriteLine(day);
    }
}
```


```csharp

using System;
using System.Collections.Generic;

public class Funcionarios
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Que dia é hoje ?");
        int dia = int.Parse(Console.ReadLine());
                switch(dia){
            case 1:
                Console.WriteLine("Domingo");
                break;
            case 2:
                Console.WriteLine("Segunda-feira");
                break;
            case 3:
                Console.WriteLine("Terça-feira");
                break;
            case 4:
                Console.WriteLine("Quarta-feira");
                break;
            case 5:
                Console.WriteLine("Quinta-feira");
                break;
            case 6:
                Console.WriteLine("Sexta-feira");
                break;
            case 7:
                Console.WriteLine("Sábado");
                break;
            default:
                Console.WriteLine("Dia não definido");
                break;
        }
    }
}
```

## If-ternário

```csharp
using System;
using System.Globalization;
class Course {
    class Program {
        static void Main(string[] args){
            double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double desconto;

            if(preco < 20.0){
                desconto = preco * 0.1;
            } else {
                desconto = preco * 0.05;
            }

            Console.WriteLine(desconto);
        }
    }
}

```

```csharp
using System;
using System.Globalization;
class Course {
    class Program {
        static void Main(string[] args){
            double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double desconto = (preco < 20.0) > preco * 0.1 : preco * 0.06;
 
            Console.WriteLine(desconto);
        }
    }
}

```


## Funções interessantes para strings
```csharp
using System;

namespace Course {
    class Program {
        static void Main(string[] args){
            string original = "abcd FGHIJ ABC abc DEFG";

            string s1 = original.ToUpper();
            string s2 = original.ToLower();
            string s3 = original.Trim();
            int n1 = original.IndexOf("bc");
            int n2 = original.LastIndexOf("bc");

            int s4 = original.Subscring(3);

            int s5 = original.Subscring(3, 5);

        }
    }
}

```


## DateTime em C#
Em C#, a estrutura DateTime é usada para representar datas e horários. Ela oferece diversos métodos para trabalhar com datas, horas, fusos horários, além de operações como formatação, análise e cálculos.

```chsarp
    using System;
    DateTime minhaData = new DateTime(2024, 9, 20); // 20 de setembro de 2024
    DateTime minhaDataHora = new DateTime(2024, 9, 20, 14, 30, 0); // 20 de setembro de 2024, 14:30=
```

### Obtendo a Data e Hora Atual
Para obter a data e hora atual, use DateTime.Now para o horário local ou DateTime.UtcNow para UTC:

```csharp
DateTime dataHoraAtual = DateTime.Now;
DateTime dataHoraUtcAtual = DateTime.UtcNow;
```


## Propriedades Comuns
 - Year (Ano), Month (Mês), Day (Dia): Acessa partes da data.
 - Hour (Hora), Minute (Minuto), Second (Segundo): Acessa partes da hora.


**Exemplo:**

```csharp
int ano = dataHoraAtual.Year;
int mes = dataHoraAtual.Month;
int dia = dataHoraAtual.Day;
```