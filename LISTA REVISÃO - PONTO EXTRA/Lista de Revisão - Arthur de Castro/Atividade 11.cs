int ouroJogador = 100;

Console.WriteLine("Máquina de Poção");
Console.WriteLine("[1] Cura - 20g | [2] Força - 30g | [3] Mana - 25g");
int escolhaPocao = int.Parse(Console.ReadLine());

switch (escolhaPocao)
{
    case 1:
        ouroJogador -= 20;
        Console.WriteLine("Você comprou Poção de Cura.");
        break;
    case 2:
        ouroJogador -= 30;
        Console.WriteLine("Você comprou Poção de Força.");
        break;
    case 3:
        ouroJogador -= 25;
        Console.WriteLine("Você comprou Poção de Mana.");
        break;
    default:
        Console.WriteLine("Opção inválida.");
        break;
}
Console.WriteLine($"Ouro restante: {ouroJogador}");