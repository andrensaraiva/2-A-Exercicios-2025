int pd = 30;
int f = 0, a = 0, i = 0;


Console.WriteLine("Voce tem 30 pontos para distribuir: ");
Console.WriteLine(" ");
Console.WriteLine("Quantos pontos deseja colocar em força?");
f = int.Parse(Console.ReadLine());
pd -= f;
Console.WriteLine("Quantos pontos deseja colocar em agilidade?");
a = int.Parse(Console.ReadLine());
pd -= a;
Console.WriteLine("Quantos pontos deseja colocar em inteligência?");
i = int.Parse(Console.ReadLine());
pd -= i;

Console.WriteLine("Distribuição Final");
Console.WriteLine("Força = " + f);
Console.WriteLine("Agilidade = " + a);
Console.WriteLine("Inteligência = " + i);
Console.WriteLine("Pontos restantes = " + pd);




