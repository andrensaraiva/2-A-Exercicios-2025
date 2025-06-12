Console.WriteLine("Quantas moedas de ouro você tem?");
int moeda = int.Parse(Console.ReadLine());
Console.WriteLine("Você é membro da Guilda? (sim/nao)");
string guilda = Console.ReadLine();

if (moeda >=100 && guilda == "sim")
{
    Console.WriteLine("Você consegue comprar itens da guilda");
}
else if (moeda >= 100 && guilda == "não")
{
    Console.WriteLine("Você não pode comprar os itens da guilda");
}
else if (moeda <100 && guilda == "sim")
{
    Console.WriteLine("Junte moedas para conseguir itens da guilda");
}
else if (moeda < 100 && guilda == "não")
{
    Console.WriteLine("Você não consegue comprar itens");
}
