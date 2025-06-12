using System.ComponentModel.Design;

string G, O, PA;

Console.WriteLine("Um portal só se estabiliza com artefatos mágicos ou alto poder.");

Console.WriteLine("Você tem a Gema Estelar?");
G = Console.ReadLine();
Console.WriteLine("Você tem o Orbe Lunar?");
O = Console.ReadLine();
Console.WriteLine("Seu Poder Arcano é maior que 50?");
PA = Console.ReadLine();

if (G == "sim" & O == "sim")
{
    Console.WriteLine("Voce tem permissão para passar");
}
else if (PA == "sim")
{
    Console.WriteLine("Voce tem permissao para passar");
}
else
{
    Console.WriteLine("Voce não tem permissao para passar");
}