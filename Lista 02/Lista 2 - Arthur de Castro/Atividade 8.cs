int a, b;

Console.WriteLine("Calcudora de Dano");
Console.WriteLine();
Console.WriteLine("Dano do Herói");
a = int.Parse(Console.ReadLine());
Console.WriteLine("Defesa do Inimigo");
b = int.Parse(Console.ReadLine());

Console.WriteLine("Dano causado é " + (a-b));
