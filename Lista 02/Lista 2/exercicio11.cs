int Tcelsius = 11;

Console.WriteLine("quantos graus Celcius você quer converter?");
Tcelsius = int.Parse(Console.ReadLine());

Console.WriteLine("isso em Fahrenheit: " + (Tcelsius * 9 / 5 + 32));