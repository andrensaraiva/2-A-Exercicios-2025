int num1;
int num2;
int soma = 100;

Console.WriteLine("Digite o primeiro número");
num1 = int.Parse(Console.ReadLine());
Console.WriteLine("Digite o segundo número");
num2 = int.Parse(Console.ReadLine());

soma = num1 + num2;

Console.WriteLine("A soma de " + num1 + " + " + num2 + " é: " + soma);
