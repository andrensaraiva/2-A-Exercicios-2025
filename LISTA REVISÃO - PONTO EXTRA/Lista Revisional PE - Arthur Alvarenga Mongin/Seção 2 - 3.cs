Console.WriteLine("Escolha o tipo do seu ataque: (Fogo, Agua ou Grama)");
string tipoescolhido = Console.ReadLine();
Console.WriteLine("Escolha o tipo do inimigo: (Fogo, Agua ou Grama)");
string tipodoinimigo = Console.ReadLine();
if (tipoescolhido == "Fogo" &&  tipodoinimigo == "Grama" || tipoescolhido == "Agua" && tipodoinimigo == "Fogo" || tipoescolhido == "Grama" && tipodoinimigo == "Agua")
{
    Console.WriteLine("É super eficaz!");
}
else if (tipoescolhido == "Fogo" && tipodoinimigo == "Fogo" || tipoescolhido == "Agua" && tipodoinimigo == "Agua" || tipoescolhido == "Grama" && tipodoinimigo == "Grama")
{
    Console.WriteLine("É pouco eficaz!");
}
else
{
    Console.WriteLine("Dano normal.");
}