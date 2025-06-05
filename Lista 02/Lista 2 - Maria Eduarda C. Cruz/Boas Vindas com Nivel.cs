// Boas Vindas com Nivel

string usuario = "";
int nivel = 0;
Console.WriteLine("Digite o seu nome e o seu nivel inicial: ");
usuario = Console.ReadLine();
nivel = int.Parse(Console.ReadLine());
Console.WriteLine("Bem-vindo(a), " + usuario + "! Você comeca no nivel " + nivel + ".");