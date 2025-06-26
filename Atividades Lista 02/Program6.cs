float valor1 = 1.5f;
float valor2 = 3.0f;
float valor3 = 4.5f;
float media = 3.5f;

Console.WriteLine("Digite três números decimais.");
Console.WriteLine("Digite o primeiro número");

valor1 = float.Parse(Console.ReadLine());

Console.WriteLine("Digite o segundo número");

valor2 = float.Parse(Console.ReadLine());

Console.WriteLine("Digite o terceiro número");

valor3 = float.Parse(Console.ReadLine());

media = valor1 + valor2 + valor3 / 3;

Console.WriteLine(" A média aritmética desses três números é" + media);

