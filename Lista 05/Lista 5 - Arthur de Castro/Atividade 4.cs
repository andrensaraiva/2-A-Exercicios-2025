int resposta;

Console.WriteLine("Seletor de Dificuldade");
Console.WriteLine("[1] Fácil - Aventura Relaxante, [2] Normal -Desafio Equilibrado, [3] Difícil - Sobrevivência Intensa, [4] Pesadelo -Sofrimento Garantido");
resposta = int.Parse(Console.ReadLine());
switch (resposta)
{
    case 1:
        Console.WriteLine("HP dos Inimigos: 50, Dano do Jogador: +20%");
        break;
    case 2:
        Console.WriteLine("HP dos Inimigos: 100, Dano do Jogador: Normal");
        break;
    case 3:
        Console.WriteLine("HP dos Inimigos: 150, Dano do Jogador: -10%, Recursos Escassos");
        break;
    case 4:
        Console.WriteLine("HP dos Inimigos: 200, Dano do Jogador: -25%, Inimigos Mais Agressivos");
        break;
    default:
        Console.WriteLine("ERROR: Mensagem não reconhecida");
        break;
}