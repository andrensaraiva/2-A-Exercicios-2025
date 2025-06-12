string a;
string b;
string c;

Console.WriteLine("Você tem a Gema Estelar? (sim/nao)");
a = (Console.ReadLine());

Console.WriteLine("Você tem o Orbe Lunar? (sim/nao)");
b = (Console.ReadLine());

Console.WriteLine("Seu Poder Arcano é maior que 50? (sim/nao)"
c = (Console.ReadLine());


if (a == "sim" && b == "sim" || c == "sim")
{
    Console.WriteLine("Pode passar meu cria");
}

else
{
    Console.WriteLine("Voce nao pode passar");
}