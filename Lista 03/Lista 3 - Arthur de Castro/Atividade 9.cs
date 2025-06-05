
int a1;
string a;

Console.WriteLine("Você entra em uma caverna com dois túneis.");
Console.WriteLine("Escolha um túnel: 1 = esquerda (úmido), 2 = direita (com brilho)");
a1 = int.Parse(Console.ReadLine());
if (a1 == 1)
{
    Console.WriteLine("Ao entrar no túnel na esquerda você ver uma espada");
    Console.WriteLine("Você pega(Sim/Não)");
    a = Console.ReadLine();
    if (a == "Sim")
    {
        Console.WriteLine("Você ganha um espada sagrada");
    }
    else
    {
        Console.WriteLine("Você vai embora, nunca se sabe");
    }
}
else if (a1 == 2)
{
    Console.WriteLine("Você entra no túnel da direita e entra em um sala branca com um grimorio");
    Console.WriteLine("Você pega(Sim/Não)");
    a = Console.ReadLine();
    if (a == "Sim")
    {
        Console.WriteLine("Você sente grande poder, mas acaba sendo almadiçoado");
    }

    else
    {
        Console.WriteLine("Você tenta sair, mas acaba preso na sala para sempre");
    }
}
