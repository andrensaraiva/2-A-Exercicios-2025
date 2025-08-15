int madeiraTotal = 0;
Random rng = new Random();

Console.WriteLine("Recursos");
while (madeiraTotal < 50)
{
    int madeiraColetada = rng.Next(5, 11);
    madeiraTotal += madeiraColetada;
    Console.WriteLine($"Coletou {madeiraColetada} madeiras. Total: {madeiraTotal}");
}
Console.WriteLine("Você coletou madeira suficiente!");
