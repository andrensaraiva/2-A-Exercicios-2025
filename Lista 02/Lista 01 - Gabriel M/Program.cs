using System.ComponentModel;
using static System.Runtime.InteropServices.JavaScript.JSType;
///Eco Numérico
int n1 = 10;

Console.WriteLine("Digite um número");
n1 = int.Parse(Console.ReadLine());
Console.WriteLine("Você Digitou o número " + n1);

///Soma Simples
int n2 = 50;
int n3 = 40;

Console.WriteLine("Digite um número");
n2 = int.Parse(Console.ReadLine());
Console.WriteLine("Digite um número");
n3 = int.Parse(Console.ReadLine());
Console.WriteLine("A soma de " + n2 + "+" + n3 + " é: " + (n2 + n3));

///Idade em Meses
int n4 = 17;

Console.WriteLine("Digite sua idade");
n4 = int.Parse(Console.ReadLine());
Console.WriteLine("A sua idade em meses é: " + (n4 * 12));

///Conversor de Moedas
int n5 = 10;

Console.WriteLine("Digite um valor em reais");
n5 = int.Parse(Console.ReadLine());
Console.WriteLine("Seu saldo em dólares é " + (n5 / 5));

///Boas-Vindas com Nível
string miguel;
int n6 = 10;

Console.WriteLine("Qual seu nome?");
miguel = (Console.ReadLine());
Console.WriteLine("Digite seu nível");
n6 = int.Parse(Console.ReadLine());
Console.WriteLine("Bem vindo(a) " + miguel + " seu nível é " + n6);

///Calculadora de Média
float n7 = 1.5f;
float n8 = 1.2f;
float n9 = 1.3f;

Console.WriteLine("Digite sua nota");
n7 = float.Parse(Console.ReadLine());
Console.WriteLine("Digite sua nota");
n8 = float.Parse(Console.ReadLine());
Console.WriteLine("Digite sua nota");
n9 = float.Parse(Console.ReadLine());
Console.WriteLine("Sua média é " + (n7 + n8 + n9) / 3);

///Área de um Retângulo
int n10 = 10;
int n11 = 10;

Console.WriteLine("Digite uma altura");
n10 = int.Parse(Console.ReadLine());
Console.WriteLine("Digite uma largura");
n11 = int.Parse(Console.ReadLine());
Console.WriteLine("Sua área é " + (n10 * n11));

///Contador de Dano Básico
int n12 = 10;
int n13 = 10;

Console.WriteLine("Qual sua força de ataque?");
n12 = int.Parse(Console.ReadLine());
Console.WriteLine("Qual a força de defesa do inimigo?");
n13 = int.Parse(Console.ReadLine());
Console.WriteLine("Seu dano é " + (n12 - n13));

///Par ou Ímpar?
int n14 = 10;

Console.WriteLine("Digite um número inteiro");
n14 = int.Parse(Console.ReadLine());
Console.WriteLine("resultado " + n14 % 2 + " se for 0 é par se for 1 é ímpar");

///Mini Loja – Cálculo de Troco
int valorpago = 60;
int item = 50;

Console.WriteLine("Seu produto custa 50 reais, pode me dar o dinheiro?");
valorpago = int.Parse(Console.ReadLine());

Console.WriteLine("Obrigado seu troco é " + (valorpago - item));

///Conversor de Temperatura
float c = 10.0f;

Console.WriteLine("Qual a temperatura de hoje?");
c = float.Parse(Console.ReadLine());
Console.WriteLine("A temperatura de hoje em fahreneheit é " + ((c * 9.0 / 5.0) + 32));

///Distribuidor de XP
int xp = 11;
int membros = 11;

Console.WriteLine("total de XP ganho pela equipe?");
xp = int.Parse(Console.ReadLine());
Console.WriteLine("número de membros?");
membros = int.Parse(Console.ReadLine());

Console.WriteLine("xp individual: " + (xp / membros) + "xp restante: " + (xp % membros));

///Calculadora de IMC
int peso = 11;
int altura = 159;

Console.WriteLine("peso?");
peso = int.Parse(Console.ReadLine());
Console.WriteLine("altura?");
int.Parse(Console.ReadLine());

Console.WriteLine("imc:" + (peso / (altura * altura)));

///Planejador de Viagem – Consumo de Combustível

Console.WriteLine("Planejador de Viagem – Consumo de Combustível");
Console.WriteLine("Digite a distância da viagem");
int n23 = int.Parse(Console.ReadLine());
Console.WriteLine("Digite o consumo do carro(km/l)");
int n24 = int.Parse(Console.ReadLine());
Console.WriteLine("Digite o preço da gasolina");
int n25 = int.Parse(Console.ReadLine());
Console.WriteLine("total de litros: " + (n23 / n24) + " valor total da viagem: " + (n25 * (n23 / n24)));

///Gerador de Status de Jogo
string tata;
int força = 10;
int agilidade = 10;
int inteligencia = 10;

Console.WriteLine("Qual o nome do seu personagem?");
tata = (Console.ReadLine());
Console.WriteLine("Qual sua força");
força = int.Parse(Console.ReadLine());
Console.WriteLine("agilidade?");
agilidade = int.Parse(Console.ReadLine());
Console.WriteLine("inteligencia?");
inteligencia = int.Parse(Console.ReadLine());
Console.WriteLine("HPBase: " + força * 5 + " Dano físico: " + (força + (agilidade / 2)) + " Poder mágico: " + inteligencia * 3);