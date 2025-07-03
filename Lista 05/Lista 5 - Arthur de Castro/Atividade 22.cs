int escolha;

Console.WriteLine("Escolha um Power-up");
Console.WriteLine("[1] Super Força");
Console.WriteLine("[2] Invisibilidade");
Console.WriteLine("[3] Cura Rápida");

escolha = int.Parse(Console.ReadLine());

switch (escolha)
{
    case 1:
        Console.WriteLine("Você ganhou força sobre-humana!");
        break;
    case 2:
        Console.WriteLine("Você agora está invisível aos inimigos!");
        break;
    case 3:
        Console.WriteLine("Você recuperou HP! HP atual:");
        break;
    default:
        Console.WriteLine("Escolha inválida.");
        break;
}