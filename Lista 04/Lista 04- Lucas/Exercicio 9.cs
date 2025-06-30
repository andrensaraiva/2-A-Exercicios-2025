int vidaM = 200, vidaJ = 100;
int ataque = 20;
string a;

Console.WriteLine("Voce encontrou um monstro das trevas no vale abissal");
Console.WriteLine("A unica opção que voce tem é entrar em combate.");
Console.ReadLine();
Console.WriteLine("Sua vida: " + vidaJ);
Console.WriteLine("Dano do seu ataque: " + ataque);
Console.WriteLine("Vida do monstro: " + vidaM);
Console.WriteLine("   ");
Console.WriteLine("Voce decide atacar ou defender?");
a = Console.ReadLine();

if (a == "atacar")
{
    Console.WriteLine("Voce ataca o monstro de inflinge nele 20 de dano, deixando-o com apenas: " + (ataque - vidaM));
}
else if (a == "defender")
{
    Console.WriteLine("Voce defende um ataque poderoso do inimigo que iria custar uma de suas vidas, porém um dano foi causado a seu personagem deixando-o com apenas" + (vidaJ - 20));
}