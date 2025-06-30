Console.WriteLine("Você tem a Gema Estelar? (sim/nao)");
string resposta1 = Console.ReadLine();

Console.WriteLine("Você tem o Orbe Lunar? (sim/nao)");
string resposta2 = Console.ReadLine();

Console.WriteLine("Seu Poder Arcano é maior que 50? (sim/nao)");
string resposta3 = Console.ReadLine();


if (resposta1 == "sim" && resposta2 == "sim" || resposta3 == "sim")
{
    Console.WriteLine("portao estabiliza");
}
else
{
    Console.WriteLine("Portao nao disponivel");
}