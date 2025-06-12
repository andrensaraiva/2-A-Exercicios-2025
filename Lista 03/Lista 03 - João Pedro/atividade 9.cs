int tunel;
string escolha;
string escolha2;

Console.WriteLine("Escolha um túnel: 1 = esquerda (úmido), 2 = direita (com brilho)");
tunel = int.Parse(Console.ReadLine());

{
    if (tunel == 1)
    {
        Console.WriteLine("Você sente o chão escorregadio");
        Console.WriteLine("Continuar mesmo assim ou voltar? (continuar / voltar)");
        escolha = Console.ReadLine();
        if (escolha == "continuar")
        {
            Console.WriteLine("Você escorrega, mas cai em um local com tesouros");
        }
        else if (escolha == "voltar")
        {
            Console.WriteLine("Você volta, mas sem descobrir os segredos da caverna");
        }
        else
        {
            Console.WriteLine("Você fica parado, ouvindo o barulho da caverna");
        }
    }
    else if (tunel == 2)
    {
        Console.WriteLine("O brilho aumenta...");
        Console.WriteLine("Tocar no cristal ou ignorar? (tocar/ignorar)");
        escolha2 = Console.ReadLine();

        if (escolha2 == "tocar")
        {
            Console.WriteLine("Você ganha poderes temporários");
        }
        else if (escolha2 == "ignorar")
        {
            Console.WriteLine("Você ignora e continua por um túnel escuro");
        }
        else
        {
            Console.WriteLine("O brilho sumiu");
        }
    }
    else
    {
        Console.WriteLine("Você fica perdido na entrada da caverna");
    }
}