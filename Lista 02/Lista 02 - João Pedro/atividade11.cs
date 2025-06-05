float celsius;
float f;

Console.WriteLine("Digite a temperatura em Celsius");
celsius = float.Parse(Console.ReadLine());

f = (celsius * 9 / 5) + 32;
Console.WriteLine("A temperatura em Fahrenheit é: " + f);
