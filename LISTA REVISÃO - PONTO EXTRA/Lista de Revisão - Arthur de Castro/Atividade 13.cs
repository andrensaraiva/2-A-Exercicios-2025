
Console.WriteLine("NPC com Personalidades Múltiplas");
Console.Write("Digite o estado emocional (1-Feliz, 2-Neutro, 3-Triste, 4-Irritado): ");
int estadoEmocional = int.Parse(Console.ReadLine());

switch (estadoEmocional)
{
    case 1:
        Console.WriteLine("Olá, amigo!"); 
        break;
    case 2:
        Console.WriteLine("Oi.");
        break;
    case 3:
        Console.WriteLine("Hoje não está fácil..."); 
        break;
    case 4: 
        Console.WriteLine("O que você quer?!"); 
        break;
    default: 
        Console.WriteLine("Emoção desconhecida"); 
        break;
}