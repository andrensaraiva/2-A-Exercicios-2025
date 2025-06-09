float distancia;
float consumoMedio;
float precoGasolina;

Console.WriteLine("Qual a distancia da sua viagem?");
distancia = float.Parse(Console.ReadLine());
Console.WriteLine("Qual o consumo medio do seu carro?");
consumoMedio = float.Parse(Console.ReadLine());
Console.WriteLine("Qual o preço da gasolina?");
precoGasolina = float.Parse(Console.ReadLine());

Console.WriteLine("Voce ira usar " + (distancia / consumoMedio) + " litro(s), e seu custo de viagem sera de " + (precoGasolina / distancia) + " reais");
