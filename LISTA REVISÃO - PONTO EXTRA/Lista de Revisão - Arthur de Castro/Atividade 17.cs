int[] danos = new int[5];
int totalDano = 0;

Console.WriteLine("Histórico de Batalha");
for (int i = 0; i < 5; i++)
{
    Console.Write($"Digite o dano do turno {i + 1}: ");
    danos[i] = int.Parse(Console.ReadLine());
    totalDano += danos[i];
}
Console.WriteLine($"Dano total: {totalDano}");
Console.WriteLine($"Dano médio: {totalDano / 5} ");