int nivel;

Console.WriteLine("Qual é o seu nível atual? (em numéro)");
nivel = int.Parse(Console.ReadLine());

{
    if (nivel >= 5)
    {
        Console.WriteLine("Você é forte o bastante! A caverna se abre.");
    }
    else
    {
        Console.WriteLine("Volte quando estiver mais forte, Elara.");
    }
}
