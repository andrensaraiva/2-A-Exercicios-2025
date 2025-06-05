String Adjetivo = "1";
String Personagem = "2";
String Verbo = "3";
String Lugar = "4";
String Objeto = "5";
String Sentimento = "6";

Console.WriteLine("Me diga seu nome: ");
Personagem = Console.ReadLine();

Console.WriteLine("Um adjetivo que te define: ");
Adjetivo = Console.ReadLine();

Console.WriteLine("O que vai fazer?");
Verbo = Console.ReadLine();

Console.WriteLine("Onde vai?");
Lugar = Console.ReadLine();

Console.WriteLine("Sua Arma? ");
Objeto = Console.ReadLine();

Console.WriteLine("Com o sentimento de? ");
Sentimento = Console.ReadLine();

Console.WriteLine( Personagem + ", o(a) " + Adjetivo + ", decidiu " + Verbo + " até a(o) " + Lugar + ". Com o(a) " + Objeto + " em mãos e cheio(a) de " + Sentimento + ", nada poderia detê-lo(a)!");


