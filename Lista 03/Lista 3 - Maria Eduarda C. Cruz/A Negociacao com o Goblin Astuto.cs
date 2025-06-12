// A Negociacao com o Goblin Astuto

string humor = "";
string olhoded = "";
Console.WriteLine("O goblin esta de bom humor hoje? (sim/nao)");
humor = Console.ReadLine();
Console.WriteLine("Voce tem um 'Olho de Dragao Polido'? (sim/nao)");
olhoded = Console.ReadLine();
if (humor == "sim" || olhoded == "sim")
{
    Console.WriteLine("O goblin aceita negociar. Parabens!");
}
else
{
    Console.WriteLine("O goblin nao aceita negociar. Talvez voce deva voltar mais tarde.");
}