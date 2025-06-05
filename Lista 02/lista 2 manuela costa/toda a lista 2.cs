

float altura = 1.7f;
float moral = 23f;
double mema = 2.3;
bool vf = true;
string palavra = "lalalalala";
char umaletra = '8';
int n1;
Console.WriteLine("Nível Fácil");

Console.WriteLine("Eco Numérico");
Console.WriteLine("digite um numero inteiro.");
n1 = int.Parse(Console.ReadLine());
Console.WriteLine("Você digitou o número: " + n1);


Console.WriteLine("Soma Simples");
Console.WriteLine("digite dois numeros inteiros.");
int n11 = int.Parse(Console.ReadLine());
int n2 = int.Parse(Console.ReadLine());
Console.WriteLine("a soma de " + n11 + " + " + n2 + " é " + (n11 + n2 ));



Console.WriteLine("Idade em Meses");
Console.WriteLine("digite sua idade");
int n3 = int.Parse(Console.ReadLine());
Console.WriteLine("Você tem isso de meses  " + (n3 * 12));



Console.WriteLine("Conversor de moedas");
Console.WriteLine("digite um valor em reais");
int n4 = int.Parse(Console.ReadLine());
Console.WriteLine("Você tem isso de dólares  " + (n4 * 5));


Console.WriteLine("Boas-Vindas com Nível");
Console.WriteLine("digite seu nome");
string n5 = Console.ReadLine();
Console.WriteLine("digite seu nível");
int n6 = int.Parse(Console.ReadLine());
Console.WriteLine("Bem-vindo(a), " + n5 + "! " + "Você começa no nível " + n6);


Console.WriteLine("Nível médio");

Console.WriteLine("Calculadora de Média");
Console.WriteLine("Escreva três notas decimais");
float n7 = float.Parse(Console.ReadLine());
float n8 = float.Parse(Console.ReadLine());
float n9 = float.Parse(Console.ReadLine());
Console.WriteLine(n7 * n8 * n9);
Console.WriteLine(n7 * n8 * n9 / 3);


Console.WriteLine("Área de um Retângulo");
Console.WriteLine("digite a altura do triângulo");
float n10 = float.Parse(Console.ReadLine());
Console.WriteLine("digite a largura do triângulo");
float n12 = float.Parse(Console.ReadLine());
Console.WriteLine("o valor é " + (n10*n12));


Console.WriteLine("Contador de Dano Básico");
Console.WriteLine("digite a força de ataque do herói");
float n13 = float.Parse(Console.ReadLine());
Console.WriteLine("digite a defesa do inimigo");
float n14 = float.Parse(Console.ReadLine());
Console.WriteLine("o dano é " + (n13 - n14));


Console.WriteLine("Par ou ímpar");
Console.WriteLine("digite um número inteiro");
int n15 = int.Parse(Console.ReadLine());
Console.WriteLine(n15%2 + " se for 0 é par, se for 1 ou mais é impar");


Console.WriteLine("Mini Loja – Cálculo de Troco");
int n16 = 100;
int n17 = int.Parse(Console.ReadLine());
Console.WriteLine("o troco é " + (n17-n16));


Console.WriteLine("Conversor de Temperatura");
Console.WriteLine("digite uma temperatura em celsius");
int n18 = int.Parse(Console.ReadLine());
Console.WriteLine("esse valor em fahrenheit é " + ((n18*9.0 / 5.0) + 32));


Console.WriteLine("Distribuidor de XP");
Console.WriteLine("Digite o total de XP");
int n19 = int.Parse(Console.ReadLine());
Console.WriteLine("Digite o número de membros");
int n20 = int.Parse(Console.ReadLine());
Console.WriteLine("Cada um vai receber " + (n19/n20 ));
Console.WriteLine("O resto de será " + (n19%n20));


Console.WriteLine("Nível desafio");


Console.WriteLine("Calculadora de IMC");
Console.WriteLine("Digite o peso em kg");
int n21 = int.Parse(Console.ReadLine());
Console.WriteLine("Digite a altura em metros");
int n22 = int.Parse(Console.ReadLine());
Console.WriteLine("IMC = " + (n21/n22*n22));


Console.WriteLine("Planejador de Viagem – Consumo de Combustível");
Console.WriteLine("Digite a distância da viagem");
int n23 = int.Parse(Console.ReadLine());
Console.WriteLine("Digite o consumo do carro(km/l)");
int n24 = int.Parse(Console.ReadLine());
Console.WriteLine("Digite o preço da gasolina");
int n25 = int.Parse(Console.ReadLine());
Console.WriteLine("total de litros: " + (n23/n24) + " valor total da viagem: " + (n25 * (n23 / n24)));


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
Console.WriteLine("chocolate = 25");
int n29 = 25;
Console.WriteLine("bala = 24");
int n30 = 24;
Console.WriteLine("chiclete = 23");
int n31 = 23;
Console.WriteLine("Quantos chocolates? ");
int n32 = int.Parse(Console.ReadLine());
Console.WriteLine("subtotal chocolate: " + (n29*n32));
Console.WriteLine("Quantas balas? ");
int n33 = int.Parse(Console.ReadLine());
Console.WriteLine("subtotal bala: " + (n30 *n33));
Console.WriteLine("Quantos chicletes? ");
int n34 = int.Parse(Console.ReadLine());
Console.WriteLine("subtotal chiclete: " + (n31 * n34));
Console.WriteLine("Total: " + (n29 * n32 + n30 * n33 + n31 * n34));



Console.WriteLine("Simulador de Investimento (Juros Simples)");
Console.WriteLine("capital inicial");
int n35 = int.Parse(Console.ReadLine());
Console.WriteLine("taxa de juros anual (em %)");
int n36 = int.Parse(Console.ReadLine());
Console.WriteLine("tempo (anos)");
int n37 = int.Parse(Console.ReadLine());
Console.WriteLine("Montante: " + (n35 + (n35 * n36 * n37)));
Console.WriteLine(n36 * n37);


Console.WriteLine("Desafio do Encanador");
Console.WriteLine("comprimento do cano padrão ");
int n38 = int.Parse(Console.ReadLine());
Console.WriteLine("distância a ser coberta ");
int n39 = int.Parse(Console.ReadLine());
Console.WriteLine("quantos canos inteiros serão necessários " + (n39/n38));
Console.WriteLine("quantos canos serão cortados " + (n39%n38));



Console.WriteLine("Decodificador de Mensagem Secreta");
Console.WriteLine("uma chave numérica ");
int n40 = int.Parse(Console.ReadLine());
Console.WriteLine("uma mensagem de 3 letras ");
string n41 = (Console.ReadLine());
Console.WriteLine("Um valor numérico para cada letra ");
int n42 = int.Parse(Console.ReadLine());
int n43 = int.Parse(Console.ReadLine());
int n44 = int.Parse(Console.ReadLine());
Console.WriteLine("três números codificados "  + ((n42 + n40) +(n43 + n40) +(n44 + n40) ));



Console.WriteLine("Construtor de Avatar (Distribuição de Pontos)");
int n45 = 60;
Console.WriteLine("Divida 60 pontos");
Console.WriteLine("Força");
int n46 = int.Parse(Console.ReadLine());
Console.WriteLine("Restante:" + (n45-n46));
Console.WriteLine("Agilidade");
int n47 = int.Parse(Console.ReadLine());
Console.WriteLine("Restante:" +  ((n45 - n46) - n47));
Console.WriteLine("Inteligência");
int n48 = int.Parse(Console.ReadLine());
Console.WriteLine("Restante:" + (((n45 - n46) - n47)- n48));
Console.WriteLine("Força: " + n46);
Console.WriteLine("Agilidade: " + n47);
Console.WriteLine("Inteligência: " + n48);

