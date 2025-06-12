//  A Oferta do Ferreiro

int moedas = 0;
string usuario = "";
Console.WriteLine("Quantas moedas de ouro voce tem?");
moedas = int.Parse(Console.ReadLine());
Console.WriteLine("Voce e membro da guilda? (sim/nao)");
usuario = Console.ReadLine();
if (moedas >= 100 && usuario == "sim")
{
    Console.WriteLine("Desconto especial! Voce compra uma arma exclusiva.");
}
else if (moedas >= 100 && usuario == "nao")
{
    Console.WriteLine("Voce compra uma arma comum.");
}
else if (moedas < 100 && usuario == "sim")
{
    Console.WriteLine("Voce pode comprar uma adaga com desconto.");
}
else
{
    Console.WriteLine("Voce nao tem ouro suficiente.");
}