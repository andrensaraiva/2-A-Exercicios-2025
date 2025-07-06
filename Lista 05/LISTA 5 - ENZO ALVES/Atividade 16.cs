int numero = 0;

while (numero != 7)
{
    Console.WriteLine("Advinhe o número");
    numero = int.Parse(Console.ReadLine());
    if (numero == 7)
    {
        Console.WriteLine("Acertou");
    }
    else
    {
        Console.WriteLine("Errou");
    }
    
}