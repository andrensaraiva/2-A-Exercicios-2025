// A Caverna dos Ecos

int tunel = 0;
int tunel2 = 0;
int tunel3 = 0;
Console.WriteLine("Escolha um tunel: 1 = esquerda (umido), 2 = direita (com brilho)");
tunel = int.Parse(Console.ReadLine());
if (tunel == 1)
{
    Console.WriteLine("Voce escorrega e bate a cabeca. Quando recobra a consciencia, se depara com dois outros tuneis. Escolha: 1 = esquerda (escuro), " +
    "2 = meio (parece ter alguem), 3 = direita (cheiro estranho)");
    tunel2 = int.Parse(Console.ReadLine());
    if (tunel2 == 1)
    {
        Console.WriteLine("Voce caminha e escuta barulhos de agua. Por onde voce segue agora? 1 = esquerda (barulhos de agua mais fortes), " +
            "2 = direita (cheiro de mar)");
        tunel3 = int.Parse(Console.ReadLine());
    }
        if (tunel3 == 1)
        {
        Console.WriteLine("Voce cai em um poço de agua fundo e nao sobrevivi. FIM!");
        tunel3 = int.Parse(Console.ReadLine());
        }
        else if (tunel3 == 2)
        {
        Console.WriteLine("Voce saiu da caverna. Parabens!");
        tunel3 = int.Parse(Console.ReadLine());
        }
    else if (tunel2 == 2)
    {
        Console.WriteLine("Voce caminha pelo tunel ouvindo seus proprios passos, porém, conforme anda mais, " +
                "pensa estar ouvindo passos alem dos seus... VOCE MORREU.");
        tunel2 = int.Parse(Console.ReadLine());
    }
    else if (tunel2 == 3)
    {
        Console.WriteLine("Que cheiro e esse? De repente, tudo escurece. VOCE PERDEU.");
        tunel2 = int.Parse(Console.ReadLine());
    }
}
else if (tunel == 2)
{
    Console.WriteLine("O caminho e brilhante demais. VOCE FICOU PRESA NA CAVERNA.");
}
// Cenário: Elara entra em uma caverna com dois túneis.
//  missão:

// Pergunte: "Escolha um túnel: 1 = esquerda (úmido), 2 = direita (com brilho)"

// Depois, dependendo da escolha, crie uma nova decisão para cada túnel e as respectivas consequências.

// Use estruturas aninhadas de if.

