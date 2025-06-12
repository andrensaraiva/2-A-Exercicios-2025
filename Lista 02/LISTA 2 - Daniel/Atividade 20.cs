// 20. Construtor de Avatar (Distribuição de Pontos)


int a, b, c, d;

Console.WriteLine("Distribuidor de Ponto");
Console.WriteLine();
Console.WriteLine("Quantos pontos você tem ");
a = int.Parse(Console.ReadLine());
Console.WriteLine("Quantos você coloca em Força");
b = int.Parse(Console.ReadLine());
Console.WriteLine("Quantos pontos você coloca em Agilidade ");
c = int.Parse(Console.ReadLine());
Console.WriteLine("Quantos pontos você coloca em Inteligencia");
d = int.Parse(Console.ReadLine());
Console.WriteLine("Você agora tem " + b + " em Força, " + c + " em Agilidade e " + d + " em Inteligencia e sobrou " + (a - b - c - d) + " pontos");