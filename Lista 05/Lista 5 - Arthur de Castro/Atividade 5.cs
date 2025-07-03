string resposta;
int sala;
Console.WriteLine("Sistema de Resposta a Comandos de Jogo:");
Console.WriteLine("Você está em uma dungeon e acabou de derrotar os inimigos na sala");
Console.WriteLine("Oque você faz agora : (olhar),(curar),(seguir de sala)");
resposta = Console.ReadLine();

switch (resposta)
{
    case "olhar":
        Console.WriteLine("Você ver uma sala e um báu aonde você vai");
        Console.WriteLine("[1]Sala, [2] Báu");
        sala = int.Parse(Console.ReadLine());
        if (sala == 1)
        {
            Console.WriteLine("Você encontra uma sala dos tesouros e fica rico");
        }
        else if (sala == 2)
        {
            Console.WriteLine("O  báu era um mimíco e você morre");
        }
        break;
    case "curar":
        Console.WriteLine("Você se cura e vai seguindo caminho");
        break;
    case "seguir de sala":
        Console.WriteLine("Você segue de sala e é emboscado por uma horda e como você está sem vida você morre");
        break;
    default:
        Console.WriteLine("Mensagem não reconhecida");
        break;
}