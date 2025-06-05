// Mad Libs: Aventura no Console

string adjetivo;
string persona;
string verbo;
string lugar;
string objeto;
string senti;
Console.WriteLine("Escreva, separando com enter: ");
Console.WriteLine("Um adjetivo, um personagem de jogo que admira, um verbo no infinitivo, um lugar perigoso, um objeto magico e um sentimento.");
adjetivo = Console.ReadLine();
persona = Console.ReadLine();
verbo = Console.ReadLine();
lugar = Console.ReadLine();
objeto = Console.ReadLine();
senti = Console.ReadLine();
Console.WriteLine(persona + ", o(a) " + adjetivo + ", decidiu " + verbo + " até " + lugar + ". Com o(a) " + objeto + " em mãos e " +
    "cheio(a) de " + senti + ", nada poderia detê-lo(a)!");
