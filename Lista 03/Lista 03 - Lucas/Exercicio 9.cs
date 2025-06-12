Console.WriteLine("Elara entra em uma caverna com dois túneis.");

string a;
int a1;

Console.WriteLine("Escolha um túnel: 1 = esquerda (úmido), 2 = direita (com brilho)");
a1 = int.Parse(Console.ReadLine());
if (a1 == 1)
{
    Console.WriteLine("Voce entra em um tunel desconhecido, porem bem umido e desconfortavel.");
    Console.WriteLine("Voce deseja continuar?");
    a = Console.ReadLine();

if (a == "sim")
    {
        Console.WriteLine("Voce entra em tunel com medo, ppis de la vem sons aterrorizantes");
        Console.WriteLine("Voce deseja continuar?");
        a = Console.ReadLine();
    }
if (a == "sim")
    {
        Console.WriteLine("Voce se aventura em uma jornada desconhecida e cheia de surpresas");
    }
else 
    {
        Console.WriteLine("Voce volta pelo caminho que veio e abandona sua aventura");
    }
}
if (a1 == 2)
{
    Console.WriteLine("Voce entra em um tunel desconhecido e bem brilhante.");
    Console.WriteLine("Voce deseja continuar?");
    a = Console.ReadLine();

    if (a == "sim")
    {
        Console.WriteLine("Voce entra em tunel com uma ansiedade de saber o que estar por vir.");
        Console.WriteLine("Voce deseja continuar?");
        a = Console.ReadLine();
    }
    if (a == "sim")
    {
        Console.WriteLine("Voce se aventura em uma jornada desconhecida e cheia de surpresas");
    }
    else
    {
        Console.WriteLine("Voce volta pelo caminho que veio e abandona sua aventura");
    }
}




