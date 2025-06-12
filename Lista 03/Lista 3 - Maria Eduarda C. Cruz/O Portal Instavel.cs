// O Portal Instavel

string gema = "";
string orbe = "";
string poder = "";
Console.WriteLine("Voce tem a Gema Estelar? (sim/nao)");
gema = Console.ReadLine();
Console.WriteLine("Voce tem o Orbe Lunar? (sim/nao)");
orbe = Console.ReadLine();
Console.WriteLine("Seu Poder Arcano é maior que 50? (sim/nao)");
poder = Console.ReadLine();
if (gema == "sim" && orbe == "sim" || poder == "sim")
{
    Console.WriteLine("O portal se abre. Pode passar!");
}
else
{
    Console.WriteLine("O portal nao se abre e sua passagem e negada.");
}
