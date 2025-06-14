string a, b, c;
int d;

Console.WriteLine("Criador de Poção");
Console.WriteLine();
Console.WriteLine("Possui Pena de Grifo? (sim/não)");
a = Console.ReadLine();
Console.WriteLine("Possui Escama de Basilisco? (sim/não)");
b = Console.ReadLine();
Console.WriteLine("Possui Flor da Lua Sangrenta? (sim/não)");
c = Console.ReadLine();
Console.WriteLine("Quantas moedas de ouro possui?");
d = int.Parse(Console.ReadLine());
if (a == "sim" && b == "sim" && c == "sim " && d >= 500)
{
    Console.WriteLine("A poção foi criado com sucesso");
}
else
{
    Console.WriteLine("Algo deu errado");
}
