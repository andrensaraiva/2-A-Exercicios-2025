string PG, EB, FLS;
int moedas;

Console.WriteLine("Possui Pena de Grifo?");
PG = Console.ReadLine();
Console.WriteLine("Possui Escama de Basilisco?");
EB = Console.ReadLine();
Console.WriteLine("Possui Flor da Lua Sangrenta?");
FLS = Console.ReadLine();
Console.WriteLine("Quantas moedas de ouro possui?");
moedas = int.Parse(Console.ReadLine());

if (PG == "sim" &  EB == "sim" &  FLS == "sim" & moedas >= 500)
{
    Console.WriteLine("Sua poção esta sendo feita com sucesso");
}
else
{
    Console.WriteLine("Volte quando tiver os itens necessários");
}
