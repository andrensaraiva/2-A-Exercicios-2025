string nome;
int nivel;

Console.WriteLine("Qual o seu nome?");
nome = Console.ReadLine();
Console.WriteLine("Qual o seu nível?");
nivel = int.Parse(Console.ReadLine());

Console.WriteLine("Bem-vindo(a), " + nome + "! Você começa no nível " + nivel);
