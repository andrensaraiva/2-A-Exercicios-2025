Console.WriteLine("Você deve possuir os três ingredientes mágicos e moedas suficientes para criar uma poção poderosa.");

string p, e, f;
int m;

Console.WriteLine("Possui Pena de Grifo? (sim/não)");
p = Console.ReadLine();
Console.WriteLine("Possui Escama de Basilisco? (sim/não)");
e = Console.ReadLine();
Console.WriteLine("Possui Flor da Lua Sangrenta? (sim/não)");
f = Console.ReadLine();
Console.WriteLine("Quantas moedas de ouro possui? (valor inteiro)");
m = int.Parse(Console.ReadLine());

if (p == "sim" & e == "sim" & p == "sim" & m >= 500)
{
    Console.WriteLine("A poção foi feita com sucesso!");
}
else
{
    Console.WriteLine("Você não consegue fabricar a poção.");
}

