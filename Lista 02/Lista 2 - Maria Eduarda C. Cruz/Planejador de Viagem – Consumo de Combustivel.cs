// Planejador de Viagem – Consumo de Combustivel

float distanciakm = 0.0f;
float consumokml = 0.0f;
float gasolina = 0.0f;
float litrosnecessarios = 0.0f;
float custototal = 0.0f;
Console.WriteLine("Digite a distancia da viagem em km, o consumo médio do carro em km/l e o preço do litro da gasolina: ");
distanciakm = float.Parse(Console.ReadLine());
consumokml = float.Parse(Console.ReadLine());
gasolina = float.Parse(Console.ReadLine());
litrosnecessarios = distanciakm / consumokml;
custototal = litrosnecessarios * gasolina;
Console.WriteLine("Vao ser necessarios " + litrosnecessarios + " litros de gasolina e o custo total sera de " + custototal + " reais.");
