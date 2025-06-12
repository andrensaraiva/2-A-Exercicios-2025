
Console.WriteLine("Elara entra em uma caverna com dois túneis.");

string a;
int a1;

Console.WriteLine("Você entra em uma caverna com dois túneis.");
Console.WriteLine("Escolha um túnel: 1 = esquerda (úmido), 2 = direita (com brilho)");
a1 = int.Parse(Console.ReadLine());
if (a1 == 1)
{
    Console.WriteLine("Ao entrar no túnel completamente umido, você ve poças que parecem acídas e plantas carnivoras de alto nível");
    Console.WriteLine("Deseja continuar e correr o risco? (Sim/Não)");
    a = Console.ReadLine();
    if (a == "Sim")
    {
        Console.WriteLine("Você adquiri um cajado mestre de veneno!");
    }
    else
    {
        Console.WriteLine("Você vai embora, e nunca descobre o que acontece lá dentro");
    }
}
else if (a1 == 2)
{
    Console.WriteLine("Ao entrar no túnel no túnel da direita, você ve um enorme brilho vindo de longe, também escuta sons de monstro e um som de metais se colidindo.");
    Console.WriteLine("Dejesa continar e correr o risco? (Sim/Não)");
    a = Console.ReadLine();
    if (a == "Sim")
    {
        Console.WriteLine("Você chega ao final do tunél e encontra uma quantidade imensúravel de dinheiro!");
    }

    else
    {
        Console.WriteLine("Você tenta sair, mas acaba encuralado por armadilhas e tem seu fim ali mesmo.");
    }
}