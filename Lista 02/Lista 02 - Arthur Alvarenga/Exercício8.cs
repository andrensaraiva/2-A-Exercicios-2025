int a, b;

Console.WriteLine("Qual a força do ataque?");
a = int.Parse(Console.ReadLine());

Console.WriteLine("Qual a defesa do inimigo?");
b = int.Parse(Console.ReadLine());

Console.WriteLine("Seu dano foi de: " + (a - b));

