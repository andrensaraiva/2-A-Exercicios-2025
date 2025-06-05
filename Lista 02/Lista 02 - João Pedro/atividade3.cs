using static System.Runtime.InteropServices.JavaScript.JSType;

int num;
int idade;

Console.WriteLine("Digite sua idade em anos");
num = int.Parse(Console.ReadLine());

idade = num * 12;
Console.WriteLine("Sua idade em meses é: " + idade);