int n12 = 10;
int n13 = 10;

Console.WriteLine("Qual sua força de ataque?");
n12 = int.Parse(Console.ReadLine());
Console.WriteLine("Qual a força de defesa do inimigo?");
n13 = int.Parse(Console.ReadLine());
Console.WriteLine("Seu dano é " + (n12 - n13));