int peso = 11;
int altura = 159;

Console.WriteLine("peso?");
peso = int.Parse(Console.ReadLine());
Console.WriteLine("altura?");
int.Parse(Console.ReadLine());

Console.WriteLine("imc:" + (peso / (altura * altura)));