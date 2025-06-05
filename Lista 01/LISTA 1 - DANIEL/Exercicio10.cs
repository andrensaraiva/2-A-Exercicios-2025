// Mad Libs: Aventura no Console

using System;

string adjetivo;
string personagem;
string verbo;
string lugar;
string perigo;
string objeto;
string sentimento;

Console.WriteLine("Me diga um adjetivo");
adjetivo = Console.ReadLine();


Console.WriteLine("Agora um personagem de jogo que admira");
personagem = Console.ReadLine();


Console.WriteLine("Um verbo no infinitivo (ex: explorar, correr)");
verbo = Console.ReadLine();


Console.WriteLine("Me fale um nome de um lugar perigoso");
lugar = Console.ReadLine();


Console.WriteLine("Me fale um nome de um objeto mágico");
objeto = Console.ReadLine();


Console.WriteLine("Me fale um nome de um sentimento");
sentimento = Console.ReadLine();


Console.WriteLine(personagem + ", o(a) " + adjetivo + " decidiu " + verbo + " até a " + lugar + ". Com o(a) " + objeto + " em mãos e cheio(a) de " + sentimento + ", nada poderia detê-lo(a)!");

