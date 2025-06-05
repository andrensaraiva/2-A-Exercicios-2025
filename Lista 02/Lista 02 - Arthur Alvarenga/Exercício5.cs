string nome;
int lv;

Console.WriteLine("Qual seu username?");
nome = Console.ReadLine();

Console.WriteLine("Qual seu nível?");
lv = int.Parse(Console.ReadLine());

Console.WriteLine("Bem-vindo(a), " + nome + "! Você começa no nível " + lv);

