string adj = "";
String pers = "";
string verbInf = "";
string lugar = "";
string objMag = "";
String sent = "";

Console.WriteLine("vamos criar uma nova história de um personagem que você ja conhece. me dê um adjetivo...");
adj = Console.ReadLine();
Console.WriteLine("ótimo! Agora, um personagem que você gosta muito.");
pers = Console.ReadLine();
Console.WriteLine("o que ele pode fazer? Pense em um verbo no infinitivo...");
verbInf = Console.ReadLine();
Console.WriteLine("em qual terra perigosa ele vai se aventurar? quero saber um lugar bem perigoso.");
lugar = Console.ReadLine();
Console.WriteLine("e qual objeto mágico ele vai usar?");
objMag = Console.ReadLine();
Console.WriteLine("o que ele sente ao chegar lá? ");
sent = Console.ReadLine();

Console.WriteLine(pers + "o(a) " + adj + " , decidiu " + verbInf + " até a " + lugar + ". Com o(a) " + objMag + " em mãos e cheio(a) de " + sent + ", nada poderia detê-lo(a)!");
