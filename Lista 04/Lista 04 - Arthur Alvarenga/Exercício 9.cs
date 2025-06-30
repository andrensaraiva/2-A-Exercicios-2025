string a;
int HPM = 112, HP = 150, DN = 60;
Console.WriteLine("Você entra em um combate!");
Console.WriteLine(" ");
Console.WriteLine("HP do Monstro: 112");
Console.WriteLine(" ");
Console.WriteLine("Seu HP: 150");
Console.WriteLine("Dano: 60 ");
Console.WriteLine(" ");
Console.WriteLine("Você escolhe atacar ou defender?");
a = Console.ReadLine();
Console.WriteLine(" ");
if (a == "atacar")
{
    Console.WriteLine("Você Ataca!");
    Console.WriteLine(" ");
    Console.WriteLine("Resultado do Round:");
    Console.WriteLine(" ");
    Console.WriteLine("HP do Monstro: " + (HPM - DN));
    Console.WriteLine(" ");
    Console.WriteLine("Seu HP: " + HP);
    Console.WriteLine("Dano: 60 ");
    Console.WriteLine(" ");

}
if (a == "defender")
{
    Console.WriteLine("Você Defende!");
    Console.WriteLine(" ");
    Console.WriteLine("Resultado do Round:");
    Console.WriteLine(" ");
    Console.WriteLine("HP do Monstro: " + HPM);
    Console.WriteLine(" ");
    Console.WriteLine("Seu HP: " + (HP - 10) );
    Console.WriteLine("Dano: 60 ");
    Console.WriteLine(" ");

}