float km = 100.5f;
float consumoMédio = 50.7f;
float preçoGasolina = 6.76f;
float litros = 20;
float custoTotal = 120.50f;

Console.WriteLine("Vamos calcular seu consumo de combustível");
Console.WriteLine("Qual é a distância da sua viajem?");

km = float.Parse(Console.ReadLine());

Console.WriteLine("Qual é o consumo médio do seu carro?");

consumoMédio = float.Parse(Console.ReadLine());

Console.WriteLine("Qual é o preço da gasolina hoje?");

preçoGasolina = float.Parse(Console.ReadLine());

litros = km / consumoMédio;

custoTotal = litros * preçoGasolina;


Console.WriteLine("A quantidade que você gastou em litros foi" + litros + "E o custo total da viajem foi" + custoTotal);