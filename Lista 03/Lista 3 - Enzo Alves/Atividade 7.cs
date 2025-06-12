
string a, b, c;

Console.WriteLine("Portal Instável");
Console.WriteLine("Um portal só se estabiliza com artefatos mágicos ou alto poder");
Console.WriteLine("Você tem a Gema Estelar? (sim/nao)");
a = Console.ReadLine();
Console.WriteLine("Você tem o Orbe Lunar? (sim/nao)");
b = Console.ReadLine();
Console.WriteLine("Seu Poder Arcano é maior que 50? (sim/nao)");
c = Console.ReadLine();
if (a == "sim" && b == "sim")
{
    Console.WriteLine("Consegue Passar");
}
else if (c == "sim")
{
    Console.WriteLine("Consegue Passar");
}
else
{
    Console.WriteLine("Não consegue passar");
}