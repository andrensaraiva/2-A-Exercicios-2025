
    Console.WriteLine("O goblin está de bom humor hoje ? (sim / nao)");
string resposta1 = Console.ReadLine();

Console.WriteLine("Você tem um 'Olho de Dragão Polido'? (sim/nao)");
string resposta2 = Console.ReadLine();

if (resposta1 == "sim" || resposta2 == "sim" )
{
    Console.WriteLine("O goblin aceita negociar");
}
else
{
    Console.WriteLine("O goblin nao aceita negociar");
}