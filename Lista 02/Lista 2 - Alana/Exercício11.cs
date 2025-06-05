float c = 10.0f;

Console.WriteLine("Qual a temperatura de hoje?");
c = float.Parse(Console.ReadLine());
Console.WriteLine("A temperatura de hoje em fahreneheit é " + ((c * 9.0 / 5.0) + 32));