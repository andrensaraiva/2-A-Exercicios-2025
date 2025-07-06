int resposta;

Console.WriteLine("Npc reações");
Console.WriteLine("Qual é o humor do NPC 1:feliz, 2:neutro, 3:irritado");
resposta = int.Parse(Console.ReadLine());
switch (resposta)
{
    case 1:
        Console.WriteLine("O NPC sorri e diz: 'Que dia adorável para uma aventura, não acha?");
        break;
    case 2:
        Console.WriteLine("O NPC acena brevemente e diz: 'Olá, viajante");
        break;
    case 3:
        Console.WriteLine("O NPC franze a testa e resmunga: O quevocê quer ? Estou ocupado!");
        break;
    default:
        Console.WriteLine("O NPC parece... confuso.");
        break;
}
