// 2. A Armadilha do Enigma Triplo

string a, b, c;
int d = 1;
int f = 1;
int g = 1;


Console.WriteLine("Voce esta em uma armadilha! Precisa resolver esses tres enigmas para desativa-la e avançar.");

Console.WriteLine("     ");


Console.WriteLine("O que é o que é: Quanto mais você tira, maior fica?");
a = Console.ReadLine();

Console.WriteLine("O que é o que é: Tem dentes, mas não morde?");
b = Console.ReadLine(); 

Console.WriteLine(" O que é o que é: Anda com os pés na cabeça?");
c = Console.ReadLine();


if (a == "um buraco")
{
    d = 1;
}
if (b == "um pente")
{
    f = 1;
}
if (c == "o piolho")
{
    g = 1;
}
Console.WriteLine("Você acertou " + (d + f + g) + " enigmas");
if (d + f + g == 3)
{
    Console.WriteLine("As armadilhas foram completamente desativadas");
}
else if (d + f + g == 2)
{
    Console.WriteLine("As armadilhas foram parcialmente desativadas");
}
else
{
    Console.WriteLine("As armadilhas não foram desativadas");
}

    