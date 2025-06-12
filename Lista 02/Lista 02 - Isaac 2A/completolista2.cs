int n1 = 10;
Console.WriteLine("Digite um número inteiro");
n1 = int.Parse(Console.ReadLine());
Console.WriteLine("Você digitou o número: " + n1);

int n2 = 10;
int n3 = 10;

Console.WriteLine("Digite um número");
n2 = int.Parse(Console.ReadLine());
Console.WriteLine("Digite um outro número");
n3 = int.Parse(Console.ReadLine());
Console.WriteLine("A soma de " + n2 + "+" + n3 + " é: " + (n2 + n3));

int anos = 12;

Console.WriteLine("quantos anos vc tem?");
anos = int.Parse(Console.ReadLine());
Console.WriteLine("vc tem " + (anos * 12) + " meses");

int reais = 1;

Console.WriteLine("quantos reais vc quer converter?");
reais = int.Parse(Console.ReadLine());
Console.WriteLine("isso equivale a:" + (reais / 5) + " dólares");

string isaac;
int nivel = 12;

Console.WriteLine("qual seu nome?");
isaac = (Console.ReadLine());
Console.WriteLine("qual seu nivel?");
nivel = int.Parse(Console.ReadLine());
Console.WriteLine("Bem-vindo(a), " + isaac + "! Você começa no nível " + nivel + ".");

float nota1 = 1f;
float nota2 = 2.5f;
float nota3 = 2.2f;

Console.WriteLine("qual sua nota do 1 bimestre?");
nota1 = float.Parse(Console.ReadLine());
Console.WriteLine("qual sua nota do 2 bimestre?");
nota2 = float.Parse(Console.ReadLine());
Console.WriteLine("qual sua nota do 3 bimestre?");
nota3 = float.Parse(Console.ReadLine());
Console.WriteLine("sua nota final foi: " + (nota1 + nota2 + nota3 / 3));

float altura = 1f;
float largura = 2.5f;

Console.WriteLine("qual altura do retângulo?");
altura = float.Parse(Console.ReadLine());
Console.WriteLine("qual largura do retângulo?");
largura = float.Parse(Console.ReadLine());
Console.WriteLine("a sua área é " + (altura * largura));

int forca = 10;
int defesa = 10;

Console.WriteLine("força de ataque do herói");
forca = int.Parse(Console.ReadLine());
Console.WriteLine("a defesa do inimigo");
defesa = int.Parse(Console.ReadLine());
Console.WriteLine("resultado: " + (forca - defesa));

int inteiro = 10;

Console.WriteLine("escreva um numero inteiro");
inteiro = int.Parse(Console.ReadLine());
Console.WriteLine("resultado: " + inteiro % 2 + " se for 0 é par, se for 1 é impar");

int item1 = 100;
int valorpago = 11;

Console.WriteLine("valor da peça: 100 reais, pode me dar o dinheiro?");
valorpago = int.Parse(Console.ReadLine());
Console.WriteLine("aqui seu troco: " + (valorpago - item1));

int celsius = 11;

Console.WriteLine("quantos graus?");
celsius = int.Parse(Console.ReadLine());
Console.WriteLine("isso em F: " + (celsius * 9 / 5 + 32));

int xp = 11;
int membros = 11;

Console.WriteLine("total de XP ganho pela equipe?");
xp = int.Parse(Console.ReadLine());
Console.WriteLine("número de membros?");
membros = int.Parse(Console.ReadLine());
Console.WriteLine("xp individual: " + (xp / membros) + "xp restante: " + (xp % membros));

int peso = 11;

Console.WriteLine("peso?");
peso = int.Parse(Console.ReadLine());
Console.WriteLine("altura?");
int.Parse(Console.ReadLine());
Console.WriteLine("imc:" + (peso / (altura * altura)));


Console.WriteLine("Planejador de Viagem – Consumo de Combustível");
Console.WriteLine("Digite a distância da viagem:");
int n23 = int.Parse(Console.ReadLine());
Console.WriteLine("Digite o consumo do carro(km/l):");
int n24 = int.Parse(Console.ReadLine());
Console.WriteLine("Digite o preço da gasolina:");
int n25 = int.Parse(Console.ReadLine());
Console.WriteLine("total de litros: " + (n23 / n24) + ". Valor total da viagem: " + (n25 * (n23 / n24)));


Console.WriteLine("Gerador de Status de Jogo");
Console.WriteLine("força");
int n26 = int.Parse(Console.ReadLine());
Console.WriteLine("agilidade");
int n27 = int.Parse(Console.ReadLine());
Console.WriteLine("inteligência");
int n28 = int.Parse(Console.ReadLine());
Console.WriteLine("Hp base: " + (n26 * 5));
Console.WriteLine("Dano Físico: " + (n26 + (n27 / 2)));
Console.WriteLine("Poder Mágico: " + (n28 * 3));

Console.WriteLine("Máquina de Doces Simulada");
Console.WriteLine("chocolate = 25$");
int n29 = 25;
Console.WriteLine("bala = 24$");
int n30 = 24;
Console.WriteLine("chiclete = 23$");
int n31 = 23;
Console.WriteLine("Quantos chocolates? ");
int n32 = int.Parse(Console.ReadLine());
Console.WriteLine("subtotal chocolate: " + (n29 * n32) + "$");
Console.WriteLine("Quantas balas? ");
int n33 = int.Parse(Console.ReadLine());
Console.WriteLine("subtotal bala: " + (n30 * n33) +"$");
Console.WriteLine("Quantos chicletes? ");
int n34 = int.Parse(Console.ReadLine());
Console.WriteLine("subtotal chiclete: " + (n31 * n34) + "$");
Console.WriteLine("Total: " + (n29 * n32 + n30 * n33 + n31 * n34) + "$");


Console.WriteLine("Simulador de Investimento (Juros Simples)");
Console.WriteLine(" seu capital inicial:");
int n35 = int.Parse(Console.ReadLine());
Console.WriteLine("taxa de juros anual (em %):");
int n36 = int.Parse(Console.ReadLine());
Console.WriteLine("tempo (anos):");
int n37 = int.Parse(Console.ReadLine());
Console.WriteLine("Montante: " + (n35 + (n35 * n36 * n37)));
Console.WriteLine((n36 * n37) + " (total de juros ganhos)");


Console.WriteLine("Desafio do Encanador");
Console.WriteLine("comprimento do cano padrão ");
int n38 = int.Parse(Console.ReadLine());
Console.WriteLine("distância a ser coberta ");
int n39 = int.Parse(Console.ReadLine());
Console.WriteLine("quantos canos inteiros serão necessários: " + (n39 / n38));
Console.WriteLine("quantos canos serão cortados: " + (n39 % n38));


Console.WriteLine("Decodificador de Mensagem Secreta");
Console.WriteLine("uma chave numérica ");
int n40 = int.Parse(Console.ReadLine());
Console.WriteLine("uma mensagem de 3 letras ");
string n41 = (Console.ReadLine());
Console.WriteLine("Um valor numérico para cada letra ");
int n42 = int.Parse(Console.ReadLine());
int n43 = int.Parse(Console.ReadLine());
int n44 = int.Parse(Console.ReadLine());
Console.WriteLine("três números codificados: " + ((n42 + n40) + (n43 + n40) + (n44 + n40)));


Console.WriteLine("Construtor de Avatar (Distribuição de Pontos)");
int n45 = 60;
Console.WriteLine("Você tem 60 pontos, divida-os com sabedoria:");
Console.WriteLine("Pra força");
int n46 = int.Parse(Console.ReadLine());
Console.WriteLine("Resta:" + (n45 - n46) + " pontos");
Console.WriteLine("Para agilidade");
int n47 = int.Parse(Console.ReadLine());
Console.WriteLine("Resta:" + ((n45 - n46) - n47) + " pontos");
Console.WriteLine("Para inteligência");
int n48 = int.Parse(Console.ReadLine());
Console.WriteLine("Resta:" + (((n45 - n46) - n47) - n48) + " pontos");
Console.WriteLine("Distribuição final:");
Console.WriteLine("Força: " + n46);
Console.WriteLine("Agilidade: " + n47);
Console.WriteLine("Inteligência: " + n48);
