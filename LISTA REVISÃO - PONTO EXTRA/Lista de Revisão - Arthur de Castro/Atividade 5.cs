string nome;
string classe;
int nivel;

Console.WriteLine("Qual é seu nome?");
nome = Console.ReadLine();
Console.WriteLine("Qual sua classe");
classe = Console.ReadLine();
Console.WriteLine("Seu level");
nivel = int.Parse(Console.ReadLine());

string titulocom = ("Sir " + nome + ". o " +  classe + " de Nível " + nivel);

Console.WriteLine(titulocom);