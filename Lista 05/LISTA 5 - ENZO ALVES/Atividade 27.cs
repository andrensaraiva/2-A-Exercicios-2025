string[] opcoes = new string[3];
int NPC = 0;
int escolha;

opcoes[0] = "Cumprimentar educadamente";
opcoes[1] = "Ameaçar";
opcoes[2] = "Ignorar";

Console.WriteLine("=== Diálogo com NPC ===");
Console.WriteLine("NPC: O que você quer?");
for (int i = 0; i < 3; i++)
{
    Console.WriteLine(i+1+": " + opcoes[i]);
}

escolha = int.Parse(Console.ReadLine());

switch (escolha)
{
    case 1:
        Console.WriteLine("NPC: Prazer em conhecê-lo.");
        NPC += 5;
        break;
    case 2:
        Console.WriteLine("NPC: Ei! Respeito!");
        NPC -= 10;
        break;
    case 3:
        Console.WriteLine("NPC: Você é estranho...");
        NPC -= 2;
        break;
}

if (NPC >= 5)
{
    Console.WriteLine("O NPC parece gostar de você.");
}
else if (NPC <= -5)
{
    Console.WriteLine("O NPC está irritado com você.");
}
else
{
    Console.WriteLine("O NPC não parece ligar muito para você.");
}