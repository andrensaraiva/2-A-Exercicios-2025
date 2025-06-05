float distancia;
float consumo;
float preco;
float litros;
float custo;

Console.WriteLine("Distância?");
distancia = float.Parse(Console.ReadLine());
Console.WriteLine("Consumo médio?");
consumo = float.Parse(Console.ReadLine());
Console.WriteLine("Preço?");
preco = float.Parse(Console.ReadLine());

litros = distancia / consumo;
custo = litros * preco;

Console.WriteLine("Vão ser necessários " + litros + " litros e o custo é de " + custo);
