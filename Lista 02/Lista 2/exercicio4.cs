int reais = 0;


Console.WriteLine("Quantos reais vc quer converter?");
reais = int.Parse(Console.ReadLine());

Console.WriteLine("Convertendo isso você terá " + (reais / 5) + " dólares");
