// 1. O Alquimista Exigente

string a, b, c;
int moedas;



Console.WriteLine("Criando sua porção...");
Console.WriteLine("      ");


Console.WriteLine("Possui Pena de Grifo? (sim/não)");
a = Console.ReadLine();



Console.WriteLine("Possui Escama de Basilisco? (sim/não");
b = Console.ReadLine();



Console.WriteLine("Possui Flor da Lua Sangrenta? (sim/não)");
c = Console.ReadLine();


Console.WriteLine("Quantas moedas de ouro possui?");
moedas = int.Parse(Console.ReadLine());

if (a == "sim" && b == "sim" && c == "sim" && moedas >= 500)
{
    Console.WriteLine("Sua pocao foi criada com sucesso!");
}

else
{
    Console.WriteLine("Voce nao consegue criar sua pocao.");
}


