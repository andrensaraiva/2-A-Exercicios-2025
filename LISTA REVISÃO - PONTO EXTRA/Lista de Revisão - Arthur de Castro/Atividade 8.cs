string TipoJ;
string TipoR;

Console.WriteLine("Sistema de Dano Elemental");
Console.WriteLine("Escolha seu tipo 1 - Água , 2 - Fogo , 3 - Grama");
TipoJ = Console.ReadLine();
Console.WriteLine("Escolha o tipo do seu rival 1 - Água , 2 - Fogo , 3 - Grama");
TipoR = Console.ReadLine();

Console.WriteLine("Quanto de Dano você deu");
int dano = int.Parse(Console.ReadLine());

if (TipoJ == "1" && TipoR == "2")
{
    Console.WriteLine("Super Efetivo o dano é de " + dano * 2);
}
else if (TipoJ == "2" && TipoR == "3")
{
    Console.WriteLine("Super Efetivo o dano é de " + dano * 2);
}
else if (TipoJ == "3" && TipoR == "1")
{
    Console.WriteLine("Super Efetivo o dano é de " + dano * 2);
}
else if (TipoJ == TipoR)
{
    Console.WriteLine("É pouco eficaz deu " + dano/2 + " de dano");
}
else
{
    Console.WriteLine("Dano normal deu " + dano + " de dano");
}