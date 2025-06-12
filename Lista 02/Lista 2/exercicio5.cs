string lele;
int nivel = 17;


Console.WriteLine("Qual seu nome?");
lele = (Console.ReadLine());
Console.WriteLine("Qual seu nivel?");
nivel = int.Parse(Console.ReadLine());
Console.WriteLine("Bem-vindo(a)," + lele + "! Você começa no nível " + nivel + ".");