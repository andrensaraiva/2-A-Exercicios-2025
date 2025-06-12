// A Ponte Fragil

string jogador = "";
Console.WriteLine("A ponte parece instavel. Voce quer atravessar? ");
jogador = Console.ReadLine();
if (jogador == "sim")
{
    Console.WriteLine("Voce atravessa com cuidado e chega em seguranca. ");
}
else if (jogador == "nao")
{
    Console.WriteLine("Voce decide procurar outro caminho. Melhor prevenir!");
}
