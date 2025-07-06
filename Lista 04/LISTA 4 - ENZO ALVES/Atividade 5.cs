string a, b;
int c,g=0,h=0,j=0;

Console.WriteLine("Você tenta abrir um cofre mágico");
Console.WriteLine("Possui chave de bronze? (sim/não)");
a = Console.ReadLine();
Console.WriteLine("Código inserido (número)");
c = int.Parse(Console.ReadLine());
Console.WriteLine("Possui Amuleto da Serpente? (sim/não)");
b = Console.ReadLine();
if (a=="sim")
{
    g = 1;
}
if (c == 123)
{
    h = 1;
}
if (b=="sim")
{
    j = 1;
}
if (g+h+j ==3)
{
    Console.WriteLine("O cofre foi aberto");
}
else if (g + h + j == 2)
{
    Console.WriteLine("O cofre quase se abriu");
}
else 
{
    Console.WriteLine("O cofre nem se mexou");
}