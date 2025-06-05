float a, b;

Console.WriteLine("Área de um Retângulo");
Console.WriteLine();
Console.WriteLine("Qual é o tamanho da base(m)");
a = float.Parse(Console.ReadLine());
Console.WriteLine("Qual é a altura do retângulo(m)");
b = float.Parse(Console.ReadLine());
Console.WriteLine();
Console.WriteLine("O retângulo tem " + (a * b) + " m² de área");