int a, b,c,d;
string r;
Console.WriteLine("Sistema de Combate por Turnos");
Console.WriteLine("Sua vida");
a = int.Parse(Console.ReadLine());
Console.WriteLine("Vida do Monstro");
b = int.Parse(Console.ReadLine());
Console.WriteLine("Dano de Ataque seu");
c = int.Parse(Console.ReadLine());
Console.WriteLine("Dano do Monstro");
d = int.Parse(Console.ReadLine());
Console.WriteLine("Ação escolhida (atacar ou defender)");
r = Console.ReadLine();
if  (r == "atacar") {
    Console.WriteLine("Você deu " + c + " no Monstro ele fica com " + (b - c) + " de vida");
    Console.WriteLine("Ele támbem vai te atacar ele te da " + d + " de dano e você fica com " + (a - d) + " de vida");
}
else
{
    Console.WriteLine("Você defende o ataque do monstro, ele te da " + (d / 3) + " de dano você fica com " + (a - (d / 3)) + " de vida");
}