
Console.WriteLine("Você tem a Gema Estelar? (sim/nao)");
string respostae = Console.ReadLine();

Console.WriteLine("Você tem o Orbe Lunar? (sim/nao)");
string respostao = Console.ReadLine();

Console.WriteLine("Seu Poder Arcano é maior que 50? (sim/nao)");
string respostap = Console.ReadLine();


if (respostae == "sim" && respostao == "sim" || respostap == "sim")
{
    Console.WriteLine("portao fechado");
}
else
{
    Console.WriteLine("Portao nao disponivel");
}