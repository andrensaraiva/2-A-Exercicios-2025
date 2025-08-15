Console.WriteLine("Cinto de Utilidades");
string[] cinto = new string[4];
for (int i = 0; i < 4; i++)
{
    Console.Write($"Digite o item {i + 1}: ");
    cinto[i] = Console.ReadLine();
}
Console.WriteLine("Inventario");
for (int i = 0; i < 4; i++)
{
    Console.WriteLine($"1: {cinto[i]}");
}
