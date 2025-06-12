string a, b, c;
int d=0, f=0, g=0;
Console.WriteLine("Enigmas");
Console.WriteLine();
Console.WriteLine("O que é cheio de buracos, mas consegue reter água?");
a = Console.ReadLine();
Console.WriteLine("Qual é a fruta que vive de pijama?");
b = Console.ReadLine();
Console.WriteLine("O que é que tem coroa, mas não é rei, tem escamas, mas não é peixe?");
c = Console.ReadLine();

if (a == "esponja")
{
    d = 1;
}
if (b == "banana")
{
    f = 1;
}
if (c == "abacaxi")
{
    g = 1;
}
Console.WriteLine("Você acertou " + ( d+f+g) + " enigmas");
if (d+f+g == 3)
{
    Console.WriteLine("As armadilhas foram completamente desativadas");
}
else if (d+f+g == 2)
{
    Console.WriteLine("As armadilhas foram parcialmente desativadas");
}
else 
{
    Console.WriteLine("As armadilhas não foram desativadas");
}
