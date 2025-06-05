float a;
int b;

Console.WriteLine("Distribuidor de Xp");
Console.WriteLine();
Console.WriteLine("Digite o número de pessoas da party");
b= int.Parse(Console.ReadLine());
Console.WriteLine("Digite a quantidade de xp");
a = float.Parse(Console.ReadLine());
Console.WriteLine("Para cada um ficou " + (a/b) + " de XP");

