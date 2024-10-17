using System;
using System.Globalization;

/**
 * 
 * Fazer um programa para executar a seguinte interação com o usuário. Lendo os valores destacados em vermelho.
 * e depois mostrar os dados na tela.
 * 
 * Entre com o seu nome completo:
 *  - Fulano de tal
 * Quantos quartos tem na sua casa ?
 *  - 3
 * Entre com o preço de um produto:
 *  - 49.90
 * Entre com o seu último nome, idade e altura(mesma linha):
 *  - Green 21 1.73
 * 
 * **/


// Entrada do nome completo do usuário
Console.WriteLine("Qual é o seu nome completo ?");
string NomeCompletoUsuario = Console.ReadLine();

// Entrada quartos tem na sua casa ? 
Console.WriteLine("Quantos quartos tem na sua casa ?");
int QuartosEmSuaCasa = int.Parse(Console.ReadLine());

// Entrada de valor de algum produto
Console.WriteLine("Digite o valor de algum produto:");
float ValorProduto = float.Parse(Console.ReadLine());

// Entrada de valor último nome, idade e altura
Console.WriteLine("Digite seu último nome, idade e altura:");
string[] SeusDados = Console.ReadLine().Split(' ');

string SobreNomeUsuario = SeusDados[0];
int IdadeUsuario = int.Parse(SeusDados[1]);
double AlturaUsuario = double.Parse(SeusDados[2]);


Console.WriteLine("\nDADOS INSERIDOS:");
Console.WriteLine("Nome completo: " + NomeCompletoUsuario);
Console.WriteLine("Número de quartos: " + QuartosEmSuaCasa);
Console.WriteLine("Preço do produto: " + ValorProduto.ToString("F2", CultureInfo.InvariantCulture));
Console.WriteLine("Último nome: " + SobreNomeUsuario);
Console.WriteLine("Idade: " + IdadeUsuario);
Console.WriteLine("Altura: " + AlturaUsuario.ToString("F2", CultureInfo.InvariantCulture));