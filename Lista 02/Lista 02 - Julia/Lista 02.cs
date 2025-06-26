using System;

namespace MyCompiler {
    class Program {
       // programa construtor de avatar 20

   int total = 20;

   Console.WriteLine("Voce tem 20 pontos para distribuir em forca, agilidade e inteligencia");

   Console.WriteLine("Pontos para forca: ");
   int forca = int.Parse (Console.ReadLine());
   total = total - forca;

   Console.WriteLine("Pontos para agilidade: ");
   int agilidade = int.Parse (Console.ReadLine());
   total = total - agilidade;  

   Console.WriteLine("Pontos para inteligencia: ");
   int inteligencia = int.Parse (Console.ReadLine());
   total = total - inteligencia; 

    Console.WriteLine("Distribuicao final: forca: " + forca + ", agilidade: " + agilidade + ", inteligencia: " + inteligencia);
        
// programa decodificador de mensagem secreta 19

Console.WriteLine("Digite a chave numerica:");
int chave = int.Parse (Console.ReadLine());

Console.WriteLine("Digite o valor da primeira letra (A=1, B=2...):");
int letra1 = int.Parse (Console.ReadLine());

Console.WriteLine("Digite o valor da segunda letra:");
int letra2 = int.Parse (Console.ReadLine());

Console.WriteLine("Digite o valor da terceira letra:");
int letra3 = int.Parse (Console.ReadLine());

int cod1 = letra1 + chave;
int cod2 = letra2 + chave;
int cod3 = letra3 + chave;

Console.WriteLine("Mensagem codificada: " + cod1 + ", " + cod2 + ", " + cod3);


// programa desafio do encanador 18

Console.WriteLine("Digite o comprimento de cada cano (em metros):");
int comprimentoCano = int.Parse (Console.ReadLine());

Console.WriteLine("Digite a distancia a ser coberta (em metros):");
int distancia = int.Parse (Console.ReadLine());

int canosNecessarios = (distancia / comprimentoCano);
int usadoNoUltimo = distancia % comprimentoCano;

Console.WriteLine("Canos inteiros necessarios: " + canosNecessarios);
Console.WriteLine("Usado no ultimo cano: " + usadoNoUltimo + " metros");


// programa simulador de investimento 17

Console.WriteLine("Digite o capital inicial:");
float capital = float.Parse (Console.ReadLine());

Console.WriteLine("Digite a taxa de juros anual (%):");
float taxa = float.Parse (Console.ReadLine());

Console.WriteLine("Digite o tempo (anos):");
float tempo = float.Parse (Console.ReadLine());

float juros = capital * (taxa / 100f) * tempo;
float montante = capital + juros;

Console.WriteLine("Montante final: R$ " + montante);
Console.WriteLine("Total de juros ganhos: R$ " + juros);


// programa máquina de doces 16

float precoChocolate = 2.50f;
float precoBala = 1.00f;
float precoChiclete = 0.75f;

Console.WriteLine("Quantos chocolates voce quer?");
int qtdChocolate = int.Parse (Console.ReadLine());

Console.WriteLine("Quantas balas voce quer?");
int qtdBala = int.Parse (Console.ReadLine());

Console.WriteLine("Quantos chicletes voce quer?");
int qtdChiclete = int.Parse (Console.ReadLine());

float subtotalChocolate = qtdChocolate * precoChocolate;
float subtotalBala = qtdBala * precoBala;
float  subtotalChiclete = qtdChiclete * precoChiclete;
float total = subtotalChocolate + subtotalBala + subtotalChiclete;

Console.WriteLine("Subtotal chocolate: R$ " + subtotalChocolate);
Console.WriteLine("Subtotal bala: R$ " + subtotalBala);
Console.WriteLine("Subtotal chiclete: R$ " + subtotalChiclete);
Console.WriteLine("Total da compra: R$ " + total);


// programa gerador de status de jogo 15

Console.WriteLine("Digite o nome do personagem:");
string nome = Console.ReadLine();

Console.WriteLine("Digite a forca:");
int forca = int.Parse (Console.ReadLine());

Console.WriteLine("Digite a agilidade:");
int agilidade = int.Parse (Console.ReadLine());

Console.WriteLine("Digite a inteligencia:");
int inteligencia =int.Parse (Console.ReadLine());

int hpBase = forca * 5;
float danoFisico = forca + (agilidade / 2.0f);

Console.WriteLine("Personagem: " + nome);
Console.WriteLine("HP base: " + hpBase);
Console.WriteLine("Dano fisico: " + danoFisico);



// programa planejador de viagem 14

Console.WriteLine("Digite a distancia da viagem (km):");
int distancia = int.Parse (Console.ReadLine());

Console.WriteLine("Digite o consumo medio do carro (km/l):");
int consumo = int.Parse (Console.ReadLine());

Console.WriteLine("Digite o preco do litro da gasolina:");
int precoLitro =  int.Parse (Console.ReadLine());

int litros = distancia / consumo;
int custoTotal = litros * precoLitro;

Console.WriteLine("Litros necessarios: " + litros);
Console.WriteLine("Custo total da viagem: R$ " + custoTotal);



// programa calculadora de IMC 13

Console.WriteLine("Digite seu peso (em kg):");
int peso =  int.Parse (Console.ReadLine());

Console.WriteLine("Digite sua altura (em metros):");
float altura =  float.Parse (Console.ReadLine());

float imc = peso / (altura * altura);

Console.WriteLine("Seu IMC e: " + imc);


PROGRAMA DE NIVEL MEDIO 

// programa distribuidor de xp 12

Console.WriteLine("Digite o total de XP ganho pela equipe:");
int totalXP = int.Parse (Console.ReadLine());

Console.WriteLine("Digite o numero de membros da equipe:");
int membros =int.Parse (Console.ReadLine());

int xpPorPessoa = totalXP / membros;
int sobra = totalXP % membros;

Console.WriteLine("Cada membro recebe: " + xpPorPessoa + " XP");
Console.WriteLine("XP que sobra: " + sobra);

// programa conversor de temperatura 11 

Console.WriteLine("Digite a temperatura em Celsius:");
float celsius = float.Parse (Console.ReadLine());
float fahrenheit = (celsius * 9.0f / 5.0f ) + 32f;

Console.WriteLine("Temperatura em Fahrenheit: " + fahrenheit);


// programa calculo de troca 10

float preco = 10.0f;

Console.WriteLine("Digite o valor pago pelo cliente:");
float pago = float.Parse (Console.ReadLine());

float troco = pago - preco;

Console.WriteLine("O troco e: " + troco);


// programa par ou impar 9

Console.WriteLine("Digite um numero inteiro:");
int numero = int.Parse (Console.ReadLine());

int resto = numero % 2;

Console.WriteLine("Resto da divisao por 2: " + resto);

if (resto == 0)
{
    Console.WriteLine("O numero é par.");
}
else
{
    Console.WriteLine("O numero é ímpar.");
}


// programa contador de dano basico 8

Console.WriteLine("Digite a forca de ataque do heroi:");
int ataque =  int.Parse (Console.ReadLine());

Console.WriteLine("Digite a defesa do inimigo:");
int defesa = int.Parse (Console.ReadLine());

int dano = ataque - defesa;

Console.WriteLine("O dano causado foi: " + dano);


// programa área do retângulo 7 

Console.WriteLine("Digite a altura do retangulo:");
int altura = int.Parse (Console.ReadLine());

Console.WriteLine("Digite a largura do retangulo:");
int largura =  int.Parse (Console.ReadLine());

int area = altura * largura;

Console.WriteLine("A area do retangulo é: " + area);

// programa calculadora de media 6
Console.WriteLine("Digite a primeira nota:");
int nota1 =  int.Parse (Console.ReadLine());

Console.WriteLine("Digite a segunda nota:");
int nota2 =  int.Parse (Console.ReadLine());

Console.WriteLine("Digite a terceira nota:");
int nota3 = int.Parse (Console.ReadLine());

int media = (nota1 + nota2 + nota3) / 3;

Console.WriteLine("A media das notas é: " + media);


PROGRAMAS DE NÍVEL FÁCIL

// programa boas-vindas com nível 5

Console.WriteLine("Qual é o seu nome?");
string nome =  Console.ReadLine();
Console.WriteLine("Qual é o seu nivel?");
int nivelIncial =  int.Parse (Console.ReadLine());

Console.WriteLine("Bem-vindo(a), " + nome + "!" + "Voce comeca no nivel" nivel);


// programa conversor de moedas 4

Console.WriteLine("Digite o valor em reais:");
float reais = float.Parse(Console.ReadLine());

float taxa = 5.0f;
float dolares = reais / taxa;

Console.WriteLine("O valor em dolares é: " + dolares);



// programa idade em meses 3

Console.WriteLine(Qual é sua idade?);
int idade = int.Parse (Console.ReadLine());

int multiplicacao = idade * 12;

Console.WriteLine("Sua idade em meses é: " + multiplicacao);


// programa soma simples 2

Console.WriteLine("Digite dois numeros inteiros");
int num1 = int.Parse (Console.ReadLine());
int num2 = int.Parse (Console.ReadLine());

int soma = num1 + num2;

Console.WriteLine("A soma de" + num1+ "e" + num2 + "é:" + soma);


// programa eco numérico 1

Console.WriteLine("Escreva um numero inteiro");
int numeroInteiro = Console.ReadLine();
 
Console.WriteLine("Voce digitou o número: " + numeroInteiro)
        }
    }
}