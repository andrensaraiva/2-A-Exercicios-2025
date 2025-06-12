string a, b;
Console.WriteLine("Um goblin comerciante só negocia se estiver de bom humor ou se receber um item raro.");
Console.WriteLine(" ");
Console.WriteLine("O goblin está de bom humor hoje? (sim/nao)");
a = Console.ReadLine();
Console.WriteLine("Você tem um 'Olho de Dragão Polido'? (sim/nao)");
b = Console.ReadLine();

if (a == "sim" || b == "sim")
{
    Console.WriteLine("Você consegue negociar com o goblin!");
}
else
{
    Console.WriteLine("Você não conseguiu negociar com o goblin");
}