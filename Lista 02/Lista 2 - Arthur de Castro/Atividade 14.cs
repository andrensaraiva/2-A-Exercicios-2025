float a, b,c;

Console.WriteLine("Planejador de Viagem");
Console.WriteLine();
Console.WriteLine("Distância da viagem(km)");
a = float.Parse(Console.ReadLine());
Console.WriteLine("Consumo médio do carro(km/l)");
b = float.Parse(Console.ReadLine());
Console.WriteLine("Preço da Gasolina");
c = float.Parse(Console.ReadLine());
Console.WriteLine("Serão necessários " + (a/b) + " Litros e o custo total vai ser R$" + (a/b)*c);
