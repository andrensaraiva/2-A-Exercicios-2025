string adjetivo = "a";
string personagem = "b";
string verbo = "c";
string lugar = "d";
string objeto = "e";
string sentimento = "f";

Console.WriteLine(" me fale um adjetivo");
adjetivo = Console.ReadLine();

Console.WriteLine(" me fale um personagem que você gosta");
personagem = Console.ReadLine();

Console.WriteLine(" me fale um verbo no infinitivo");
verbo = Console.ReadLine();

Console.WriteLine(" me fale um lugar perigoso");
lugar = Console.ReadLine();

Console.WriteLine(" me fale um objeto mágico");
objeto = Console.ReadLine();    

Console.WriteLine(" me fale um sentimento");
sentimento = Console.ReadLine();

Console.WriteLine(personagem + ", o " + adjetivo + ", decidiu " + verbo + " até a " + lugar + ". Com o " + objeto + " em mãos e cheio de " + sentimento + ", nada poderia detê-lo");
