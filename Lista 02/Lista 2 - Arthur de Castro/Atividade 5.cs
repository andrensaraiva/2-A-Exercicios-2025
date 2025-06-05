int a;
string b;

Console.WriteLine("Fale seu nome");
b = Console.ReadLine();
Console.WriteLine("Agora fale seu level");
a = int.Parse(Console.ReadLine());

Console.WriteLine("Seja bem vindo " + b + "! Seu level atual é " + a);
