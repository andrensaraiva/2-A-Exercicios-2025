int hpChefe = 100;

Console.WriteLine("Batalha Final");
while (hpChefe > 0)
{
    Console.WriteLine("Combo de 3 golpes!");
    for (int i = 0; i < 3; i++)
    {
        Random rng = new Random();
        int danoGolpe = rng.Next(5, 16);
        hpChefe -= danoGolpe;
        Console.WriteLine($"Golpe {i + 1}: causou {danoGolpe} de dano.");
    }
    Console.WriteLine($"HP do Chefe: {hpChefe}");
}
Console.WriteLine("Vitória! Você derrotou o chefe!");
