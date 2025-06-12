Console.WriteLine("Você tem a Gema Estelar? (sim/nao)");
string gema = Console.ReadLine();
Console.WriteLine("Você tem o Orbe Lunar? (sim/nao)");
string orbe = Console.ReadLine();
Console.WriteLine("Seu Poder Arcano é maior que 50? (sim/nao)");
string arcano = Console.ReadLine();

if (gema == "sim" && orbe == "sim" || arcano == "sim")
{
    Console.WriteLine("Você atravessa passagem.");
}
else if (gema == "sim" && orbe == "nao" || arcano == "sim")
{
    Console.WriteLine("Você atravessa passagem.");
}
else if (gema == "nao" && orbe == "sim" || arcano == "sim")
{
    Console.WriteLine("Você atravessa passagem.");
}
else if (gema == "nao" && orbe == "nao" || arcano == "sim")
{
    Console.WriteLine("Você atravessa passagem.");
}
else if (gema == "nao" && orbe == "nao" || arcano == "nao")
{
    Console.WriteLine("Você não atravessa passagem.");
}
else if (gema == "sim" && orbe == "sim" || arcano == "nao")
{
    Console.WriteLine("Você atravessa passagem.");
}