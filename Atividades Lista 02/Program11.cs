float celsius = 50;
float Fahreinheit = 132;

Console.WriteLine("Escreva uma temperatura em °C");

celsius = float.Parse(Console.ReadLine());

Fahreinheit = celsius * 9.0f / 5.0f + 32;

Console.WriteLine("Este valor em Fahreinheit é igual a" + Fahreinheit);


