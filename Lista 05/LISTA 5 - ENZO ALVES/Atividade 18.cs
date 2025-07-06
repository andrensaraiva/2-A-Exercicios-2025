int vb, vv;
vb = 30;
vv = 10;

Console.WriteLine("Batalha Contra Monstro");
Console.WriteLine("Elara luta contra um Goblin com 30 de HP.Elara causa 10 de dano por ataque.");
while (vb != 0)
{
    Console.WriteLine("Você ataca o Goblin");
    vb = (vb - vv);
    Console.ReadLine();
    Console.WriteLine("Vida do Goblin " + vb);
}
Console.WriteLine("Você derrotou o Goblin");