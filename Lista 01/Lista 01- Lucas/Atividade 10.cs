string adjetivo = "1";
string personagem = "2";
string verbo_infinitivo = "3";
string lugar_perigoso = "4";
string objeto_magico = "5";
string sentimento = "6";

Console.WriteLine("Me diga um adjetivo");
adjetivo = Console.ReadLine();

Console.WriteLine("Me diga um personagem");
personagem = Console.ReadLine();

Console.WriteLine("Me diga um verbo");
verbo_infinitivo = Console.ReadLine();

Console.WriteLine("Me diga um lugar");
lugar_perigoso = Console.ReadLine();

Console.WriteLine("Me diga um objeto magico");
objeto_magico = Console.ReadLine();

Console.WriteLine("Me diga um sentimento");
sentimento = Console.ReadLine();

Console.WriteLine(personagem + " o(a) " + adjetivo + ", decidiu " + verbo_infinitivo + " até a " + lugar_perigoso + " Com o(a) " + objeto_magico + " em mãos e cheio(a) de " + sentimento + " nada poderia detê-lo(a)!");