// Conversor de Temperatura

float tempC = 0.0f;
float tempF = 0.0f;
tempC = float.Parse(Console.ReadLine());
tempF = (tempC * 9 / 5) + 32;
Console.WriteLine(tempF);
