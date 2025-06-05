string Verbo = "salvo";
Console.WriteLine("Escolha um verbo {ex: Lutar, Conquistar, Defender}");
Verbo = Console.ReadLine();

string Substantivo = "salvo";
Console.WriteLine("Escolha um substantivo épico {ex: Honra, Glória, Justiça}");
Substantivo = Console.ReadLine();

string Inimigo = "salvo";
Console.WriteLine(" Diga o nome do vilão");
Inimigo = Console.ReadLine();

Console.WriteLine("Pela " + Substantivo + "! Vamos " + Verbo + " e derrotar o " + Inimigo + "!");