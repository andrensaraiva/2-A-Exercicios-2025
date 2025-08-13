Console.WriteLine("Batalha Final");
int hpChefe = 100;
Random random = new Random();
for (; hpChefe > 0;)
{
    Console.WriteLine("Você usou um Combo de 3 Golpes!");
    for (int i = 1; i <= 3; i++)
    {
        int dano = random.Next(5, 16);
        hpChefe -= dano;
        if (hpChefe < 0) hpChefe = 0;
        Console.WriteLine("Golpe " + i + ": causou " + dano + " de dano. HP do Chefe: " + hpChefe);
    }
}
Console.WriteLine("Você derrotou o Chefe Final!");
    }