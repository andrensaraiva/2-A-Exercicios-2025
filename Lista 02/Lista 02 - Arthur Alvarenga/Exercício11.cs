int c, f;

Console.WriteLine("Qual temperatura deseja converter? (Celsius)");
c = int.Parse(Console.ReadLine());

Console.WriteLine("Em Farenheit: " + (f = (int)(c * 9.0 / 5.0 + 32)));
