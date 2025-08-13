string[] feitiços = { "Lua Cheia", "Pedrilhado Arcano", "Magmar", "Raio Plasidusax" };
Console.WriteLine("Feitiços em ordem inversa:");
for (int i = feitiços.Length - 1; i >= 0; i--)
{
    Console.WriteLine("- " + feitiços[i]);
}