int capitalInicial;
int taxaDeJuros;
int tempo;

Console.WriteLine("Qual o seu capital inicial?");
capitalInicial = int.Parse(Console.ReadLine());
Console.WriteLine("Qual a taxa de juros deste ano?");
taxaDeJuros = int.Parse(Console.ReadLine());
Console.WriteLine("Qual o tempo?");
tempo = int.Parse(Console.ReadLine());

Console.WriteLine("O seu montante é de: " + (capitalInicial + (capitalInicial * taxaDeJuros * tempo)));
