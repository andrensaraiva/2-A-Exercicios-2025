Console.WriteLine("Qual seu estado emocional do NPC? [1] Feliz, [2] Triste, [3] Irritado ou [4] Neutro.");
int EstadoEmocional = int.Parse(Console.ReadLine());
Console.WriteLine(" ");

switch (EstadoEmocional)
{
    case 1:
        Console.WriteLine("NPC: Que dia maravilhoso! Posso sentir a energia positiva no ar!");
        break;
    case 2:
        Console.WriteLine("NPC: Às vezes me pergunto se as coisas vão melhorar algum dia.");
        break;
    case 3:
        Console.WriteLine("O que você quer agora?! Já não tenho paciência pra isso!");
        break;
    case 4:
        Console.WriteLine("NPC: Tudo está como sempre... nada demais acontecendo.");
        break;
}
