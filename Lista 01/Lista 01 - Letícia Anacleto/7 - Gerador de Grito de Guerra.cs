// See https://aka.ms/new-console-template for more information
Console.WriteLine("Diga um verbo de ação (ex: Lutar, Conquistar, Defender).");
string verbo = Console.ReadLine();

Console.WriteLine("Diga um substantivo épico (ex: Honra, Glória, Justiça).");
string substantivo = Console.ReadLine();

Console.WriteLine("Qual o nome do inimigo principal?");
string inimigo = Console.ReadLine();

Console.WriteLine("Pela " + substantivo + "! Vamos " + verbo + " e derrotar " + inimigo + "!");
