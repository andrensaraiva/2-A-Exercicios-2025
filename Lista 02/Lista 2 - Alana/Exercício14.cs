Console.WriteLine("Planejador de Viagem – Consumo de Combustível");
Console.WriteLine("Digite a distância da viagem");
int n23 = int.Parse(Console.ReadLine());
Console.WriteLine("Digite o consumo do carro(km/l)");
int n24 = int.Parse(Console.ReadLine());
Console.WriteLine("Digite o preço da gasolina");
int n25 = int.Parse(Console.ReadLine());
Console.WriteLine("total de litros: " + (n23 / n24) + " valor total da viagem: " + (n25 * (n23 / n24)));