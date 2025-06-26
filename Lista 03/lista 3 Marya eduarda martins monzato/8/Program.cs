
Console.WriteLine("O goblin esta de bom humor hoje? (sim/nao)");
string humor = Console.ReadLine();
Console.WriteLine("Voce tem um 'Olho de Dragao Polido'? (sim/nao)");
string item = Console.ReadLine();
if (humor == "sim" || item == "sim")
{
    Console.WriteLine("O goblin aceita negociar com voce.");
}
else
{
    Console.WriteLine("O goblin rosna e se recusa a negociar.");
}