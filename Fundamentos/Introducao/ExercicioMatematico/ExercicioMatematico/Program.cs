/**
 *  Faça um programa que leia medidas de largura e comprimento de um terreno retangular,  com uma casa decimal, bem como o valor do metro quadrado do terreno com duas casas decimais. 
 *  Em seguida, o programa deve mostrar o valor da área do terreno. Bem como o valor do preço do terreno, ambos com as duas casas decimais.
 *
 */

/**
 *  Exemplo:
 *      10.0  
 *      30.00
 *      
 *  Saída:
 *      AREA = 300.00
 *      PRECO = 60000.00
 * 
 * **/

using System;
using System.ComponentModel;
using System.Globalization;

// Solicita a largura do terreno
Console.WriteLine("Digite a largura do terreno");
double largura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

// Solicita o comprimento do terreno

Console.WriteLine("Digite o valor do metro quadrado:");
double comprimento = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

Console.WriteLine("Digite o valor do metro quadrado:");
double valorMetroQuadrado = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

// Calculando a área do terreno

double area = largura * comprimento;

// Solicita o valor do metro quadrado

double preco = area * valorMetroQuadrado;

// Exibe o resultado com duas casas decimais
Console.WriteLine("AREA = " + area.ToString("F2", CultureInfo.InvariantCulture));
Console.WriteLine("PRECO = " + preco.ToString("F2", CultureInfo.InvariantCulture));