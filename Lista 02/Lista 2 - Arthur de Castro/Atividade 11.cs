float a;

Console.WriteLine("Conversor de Temperatura");
Console.WriteLine("Celsius para Fahrenheit");
Console.WriteLine();
Console.WriteLine("Digite sua temperatura");
a = float.Parse(Console.ReadLine());
Console.WriteLine("Sua temperatura é de " + (a*9/5+32) + "F°");