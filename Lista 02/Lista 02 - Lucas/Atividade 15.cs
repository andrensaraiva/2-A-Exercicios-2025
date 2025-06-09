int força;
int agilidade;
int inteligencia;
string nome;

Console.WriteLine("Qual é o seu nome de usuario?");
nome = Console.ReadLine();

Console.WriteLine("Me diga qual sua força, agilidade e nivel de inteligencia");
força = int.Parse(Console.ReadLine());
agilidade = int.Parse(Console.ReadLine());
inteligencia = int.Parse(Console.ReadLine());

Console.WriteLine("Seu nome é " + nome);
Console.WriteLine("Seu HP base é de " + (força * 5));
Console.WriteLine("Seu dano fisico é de " + (força + (agilidade / 2)));
Console.WriteLine("Poder Mágico = " + (inteligencia * 3));