float a, b;

Console.WriteLine("Calculadora de IMC");
Console.WriteLine();
Console.WriteLine("Digite seu peso(em kg)");
a = float.Parse(Console.ReadLine());
Console.WriteLine("Digite sua altura(em m)");
b = float.Parse(Console.ReadLine());
Console.WriteLine("IMC = " + (a/(b*b)));
