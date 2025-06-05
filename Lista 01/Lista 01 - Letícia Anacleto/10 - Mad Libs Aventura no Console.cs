// See https://aka.ms/new-console-template for more information
Console.WriteLine("Diga um adjetivo (ex: corajoso, medroso)");
string adjetivo = Console.ReadLine();

Console.WriteLine("Diga um personagem de jogo que admira");
string personagem = Console.ReadLine();

Console.WriteLine("Diga um verbo no infinitivo (ex: explorar, correr)");
string verbo = Console.ReadLine();

Console.WriteLine("Diga um lugar perigoso");
string lugar = Console.ReadLine();

Console.WriteLine("Diga um objeto mágico");
string objeto = Console.ReadLine();

Console.WriteLine("Diga um sentimento");
string sentimento = Console.ReadLine();

Console.WriteLine(personagem + ", o(a) " + adjetivo + ", decidiu " + verbo + " até a " + lugar + ". Com o(a) " + objeto + " em mãos e cheio(a) de " + sentimento + ", nada poderia detê-lo(a)");
