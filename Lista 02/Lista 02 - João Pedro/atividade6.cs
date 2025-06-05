float num1;
float num2;
float num3;
float soma;
float media;

Console.WriteLine("Digite o primeiro número");
num1 = float.Parse(Console.ReadLine());
Console.WriteLine("Digite o segundo número");
num2 = float.Parse(Console.ReadLine());
Console.WriteLine("Digite o segundo número");
num3 = float.Parse(Console.ReadLine());

soma = num1 + num2 + num3;
media = soma / 3;

Console.WriteLine("A média é: " + media);
