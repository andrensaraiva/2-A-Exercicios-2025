Console.WriteLine("Um guarda bloqueia seu caminho, o que deseja fazer, persuadir, subornar ou lutar?");
string decisaojogador = Console.ReadLine();
if (decisaojogador == "persuadir")
{
    Random rnd = new Random();
    int NumeroEscolhido = rnd.Next(20);
    if (NumeroEscolhido > 10)
    {
        Console.WriteLine("Voce Consegue persuadir o guarda, e passa!");
    }
    else
    {
        Console.WriteLine("O guarda se irrita.");
    }
}
else if (decisaojogador == "subornar")
{
    Console.WriteLine("Quanto ouro voce deseja oferecer pro guarda?");
    int ourodado = int.Parse(Console.ReadLine());
    if (ourodado > 50)
    {
        Console.WriteLine("Voce passa");
    }
    else
    {
        Console.WriteLine("O guarda recusa");
    }
}
else if (decisaojogador == "lutar")
{
    Console.WriteLine("Voce perde vida, mas consegue passar");
}