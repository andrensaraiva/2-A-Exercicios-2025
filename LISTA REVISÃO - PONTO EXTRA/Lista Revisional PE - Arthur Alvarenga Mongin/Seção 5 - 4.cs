Console.WriteLine("Coletando Recursos");
int madeiraTotal = 0;
Random random = new Random();
for (int turno = 1; madeiraTotal < 50; turno++)
{
    int madeiraColetada = random.Next(5, 11);
    madeiraTotal += madeiraColetada;
    Console.WriteLine("Turno " + turno + ": Coletou " + madeiraColetada + " madeiras. Total: " + madeiraTotal);
}
