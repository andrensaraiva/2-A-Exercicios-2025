int a;

Console.WriteLine("Sistema de Reputação com Facções");
Console.WriteLine();
Console.WriteLine("Você presencia Mercadores atacando uma tribo na floresta ");
Console.WriteLine("Escolha sua Ação)");
Console.WriteLine("1 = Defender a floresta");
Console.WriteLine("2 = Ajudar os mercadores");
Console.WriteLine("3 = Atacar os dois ladoS");
a = int.Parse(Console.ReadLine());
if (a == 1)
{
    Console.WriteLine("Você ganha respeito dos moradores da tribo e os mercadores te odeiam");
}
if (a == 2)
{
    Console.WriteLine("Você ganha respeito dos mercadores e os moradores da tribo te odeiam");
}
if (a == 3)
{
    Console.WriteLine("Todo mundo te odeia");
}
