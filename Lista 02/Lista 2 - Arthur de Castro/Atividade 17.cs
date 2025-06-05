float a, b;
int c;

Console.WriteLine("Calculadora de Juros Simples");
Console.WriteLine();
Console.WriteLine("Digite o Capital");
a = float.Parse(Console.ReadLine());
Console.WriteLine("Digite a taxa de juros(ex: 5%=0,05)");
b = float.Parse(Console.ReadLine());
Console.WriteLine("Digite o tempo (anos ou meses)");
c = int.Parse(Console.ReadLine());
Console.WriteLine();
Console.WriteLine("O Montante será de R$" + (a+(a * b * c)));

