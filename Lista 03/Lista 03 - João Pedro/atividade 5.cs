int cores;

Console.WriteLine("Qual botão você aperta? (1 = Vermelho, 2 = Azul, 3 = Verde)");
cores = int.Parse(Console.ReadLine());

{
    if (cores == 2)
    {
        Console.WriteLine("A porta se abre! O botão Azul estava certo.");
    }
    else if (cores == 3)
    {
        Console.WriteLine("O botão Verde não funcionou.");
    }
    else if (cores == 1)
    {
        Console.WriteLine("Nada acontece com o botão Vermelho.");
    }
    else
    {
        Console.WriteLine("Escolha inválida, Elara.");
    }
}
