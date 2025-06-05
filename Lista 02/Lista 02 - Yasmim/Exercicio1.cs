//1. Eco Numérico

int numero = 100456;
Console.WriteLine("Você digitou o número:");
numero = int.Parse(Console.ReadLine());

//2. Soma Simples

int num1 = 1;
int num2 = 2;
int resultado = 3;
resultado = num1 + num2 ;
Console.WriteLine("A soma de " + num1 + " e " + num2 + " é: " + resultado);
resultado = int.Parse(Console.ReadLine());

//3. Idade em Meses

int idade = 17;
Console.WriteLine("Escreva a sua idade");
idade = int.Parse(Console.ReadLine());

int meses = 12;
meses = meses * 12;
Console.WriteLine(" Você tem: " + idade + " anos" + " e " + meses + " meses");
meses = int.Parse(Console.ReadLine());

// 4. Conversor de Moedas

int reais = 2;
int dolar = 7;
int conversão = 14;
conversão = reais * dolar;
Console.WriteLine("A conversão de " + reais + " em " + dolar + " é: " + conversão);
resultado = int.Parse(Console.ReadLine());

// 5. Boas-Vindas com Nível

string nome = "Yasmim";
int nível = 1;
Console.WriteLine("Bem-vindo(a) " + nome + ", Você começa no nível " + nível);
nível = int.Parse(Console.ReadLine());