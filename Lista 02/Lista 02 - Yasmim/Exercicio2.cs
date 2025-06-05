//6. Calculadora de Média

float n1, n2, n3, media;
Console.WriteLine("Digite a primeira nota:");
n1 = float.Parse(Console.ReadLine());
Console.WriteLine("Digite a segunda nota:");
n2 = float.Parse(Console.ReadLine());
Console.WriteLine("Digite a terceira nota:");
n3 = float.Parse(Console.ReadLine());
media = (n1 + n2 + n3) / 3;
Console.WriteLine("Média: " + media);

//7. Área de um Retângulo

float altura, largura, area;
Console.WriteLine("Digite a altura:");
altura = float.Parse(Console.ReadLine());
Console.WriteLine("Digite a largura:");
largura = float.Parse(Console.ReadLine());
area = altura * largura;
Console.WriteLine("Área: " + area);

//8. Contador de Dano Básico

int ataque, defesa, dano;
Console.WriteLine("Força de ataque:");
ataque = int.Parse(Console.ReadLine());
Console.WriteLine("Defesa do inimigo:");
defesa = int.Parse(Console.ReadLine());
dano = ataque - defesa;
Console.WriteLine("Dano causado: " + dano);

//9. Par ou Ímpar?

int numero;
Console.WriteLine("Digite um número:");
numero = int.Parse(Console.ReadLine());
numero % 2 = 0
Console.WriteLine("Número par.");
Console.WriteLine("Número ímpar.");

//10. Mini Loja – Cálculo de Troco

double preco = 10.00, pago, troco;
Console.WriteLine("Valor pago:");
pago = double.Parse(Console.ReadLine());
troco = pago - preco;
Console.WriteLine("Troco: R$ " + troco);

//11.  Conversor de Temperatura

double celsius, fahrenheit;
Console.WriteLine("Digite a temperatura em Celsius:");
celsius = double.Parse(Console.ReadLine());
fahrenheit = (celsius * 9.0 / 5.0) + 32;
Console.WriteLine("Fahrenheit: " + fahrenheit);

//12. Distribuidor de XP

int xpTotal, membros, porPessoa, sobra;
Console.WriteLine("XP total:");
xpTotal = int.Parse(Console.ReadLine());
Console.WriteLine("Número de membros:");
membros = int.Parse(Console.ReadLine());
porPessoa = xpTotal / membros;
sobra = xpTotal % membros;
Console.WriteLine("Cada um recebe " + porPessoa + " XP. Sobra: " + sobra);
