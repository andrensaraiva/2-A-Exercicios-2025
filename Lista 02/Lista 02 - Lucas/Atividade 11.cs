int a, f;

Console.WriteLine("Quantos graus celcius esta fazendo em sua cidade?");
a = int.Parse(Console.ReadLine());

Console.WriteLine("A temperatura em farenheint em sua cidade é " + (f = (int)(a * 9.0 / 5.0 + 32)));
