string a;
int b;

Console.WriteLine("Simulador de Moral de Tropa");
Console.WriteLine("Nível inicial de moral");
b = int.Parse(Console.ReadLine());
Console.WriteLine("Evento recente (vitória, derrota)");
a = Console.ReadLine();
if (a == "vitória")
{
    b = (b + 100);
}
else 
{
    b = (b - 50);
}
if (b >=100)
{
    Console.WriteLine("A tropa está motivada");
}
else if (b >= 50)
{
    Console.WriteLine("A tropa está com o hurmo normal");
}
else if (b < 50)
{
    Console.WriteLine("A tropa está desânimada");
}