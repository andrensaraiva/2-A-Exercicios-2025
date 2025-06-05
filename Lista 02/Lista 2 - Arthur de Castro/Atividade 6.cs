float a, b, c;

Console.WriteLine("Calculadora de Média");
Console.WriteLine();
Console.WriteLine("Seu primeiro número");
a = float.Parse(Console.ReadLine());
Console.WriteLine("Seu segundo número");
b = float.Parse(Console.ReadLine());
Console.WriteLine("Seu terceiro número");
c = float.Parse(Console.ReadLine());

Console.WriteLine("Sua média é " + (a + b + c)/3);;
