string resposta1, resposta2, resposta3;

Console.WriteLine("Fale um verbo de ação (ex: Lutar, Conquistar, Defender). ");
resposta1 = Console.ReadLine();
Console.WriteLine("Fale um substantivo épico (ex: Honra, Glória, Justiça).");
resposta2 = Console.ReadLine();
Console.WriteLine("Agora fale o nome do maior inimigo");
resposta3 = Console.ReadLine();

Console.WriteLine("Pela " +  resposta2 + "!" + " Vamos " + resposta1 + " e derrotar o" + resposta3 + "!");