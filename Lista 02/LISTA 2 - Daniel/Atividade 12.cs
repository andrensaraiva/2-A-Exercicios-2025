// 12. Distribuidor de XP


int a, b;

Console.WriteLine("Qual valor de XP ganho , e quantos membros existem? ");
a = int.Parse(Console.ReadLine());
b = int.Parse(Console.ReadLine());

Console.WriteLine("Cada um recebe: " + (a / b) + ", Sobra: " + (a % b));
