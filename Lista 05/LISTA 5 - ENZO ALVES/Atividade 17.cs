bool sairdojogo = false;
while (sairdojogo == false)
{
    Console.WriteLine("Menu");
    Console.WriteLine("[1] Novo Jogo, [2] Carregar, [3] Sair");
    int resposta;
    resposta = int.Parse(Console.ReadLine());
    switch (resposta)
    {
        case 1:
            Console.WriteLine("Iniciando novo jogo...");
            break;
        case 2:
            Console.WriteLine("Iniciando novo jogo...");
            break;
        case 3:
            sairdojogo=true;
            break;

    }

} 