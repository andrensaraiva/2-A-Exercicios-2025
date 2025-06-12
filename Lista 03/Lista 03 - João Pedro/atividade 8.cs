string goblin;
string olho;

Console.WriteLine("O goblin está de bom humor hoje? (sim/nao)");
goblin = Console.ReadLine();
Console.WriteLine("Você tem um 'Olho de Dragão Polido? (sim/nao)");
olho = Console.ReadLine();

{
    if ((goblin == "sim") || (olho == "sim"))
    {
        Console.WriteLine("O goblin aceitou negociar");
    }
    else
    {
        Console.WriteLine("O goblin não aceitou negociar");
    }
}
