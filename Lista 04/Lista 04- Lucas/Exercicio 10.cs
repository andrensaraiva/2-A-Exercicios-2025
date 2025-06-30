string a;

Console.WriteLine("Voce esta andando e bandidos aparecem para te atacar");
Console.WriteLine("Voce percebe que possui uma espada na bolsa, mas esta com receio de ataca-los.");
Console.WriteLine("   ");
Console.WriteLine("Voce escolhe atacar, defender, correr ou se render?");
a = Console.ReadLine();

if (a == "atacar")
{
    Console.WriteLine("Voce ataca mas falha miseravelmente, por conta de seua falha, voce perde seus intens e 10 niveis de XP"); 
}
else if (a == "defender")
{
    Console.WriteLine("Voce defende e apenas sofre uma pequena porcentagem de dano.");
}
else if (a == "correr")
{
    Console.WriteLine("Voce corre e nao perde nada, ótima decisão.");
}
else if (a == "se render")
{
    Console.WriteLine("Voce perde todos seus itens por conta de sua covardia");
}

