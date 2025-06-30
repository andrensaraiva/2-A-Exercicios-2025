int F = 0, AG = 0, INT = 0;
int AR, Arma;

Console.WriteLine("Escolha seu set inicial!");
Console.WriteLine(" ");
Console.WriteLine("Começando por sua armadura:");
Console.WriteLine("Você deseja a armadura de guerreiro (+20 Força +5 Agilidade), mago (+30 Inteligência) ou assasino (+15 Agilidade +10 Força)? (1,2 ou 3)");
AR = int.Parse(Console.ReadLine());
if (AR == 1)
{
    F = F + 20;
    AG = AG + 5;

    Console.WriteLine("Você escolheu o set de guerreiro, seus atributos agora são: ");
    Console.WriteLine("Força: " + F);
    Console.WriteLine("Agilidade: " + AG);
    Console.WriteLine("Inteligência: " + INT);

}
else if (AR == 2)
{
    INT = INT + 30;

    Console.WriteLine("Você escolheu o set de mago, seus atributos agora são: ");
    Console.WriteLine("Força: " + F);
    Console.WriteLine("Agilidade: " + AG);
    Console.WriteLine("Inteligência: " + INT);

}
else if (AR == 3)
{
    F = F + 10;
    AG = AG + 15;

    Console.WriteLine("Você escolheu o set de assasino, seus atributos agora são: ");
    Console.WriteLine("Força: " + F);
    Console.WriteLine("Agilidade: " + AG);
    Console.WriteLine("Inteligência: " + INT);

}
Console.WriteLine(" ");
Console.WriteLine("Agora Escolha sua arma: ");
Console.WriteLine("Espada longa (+5 Força), Cajado (+5 Inteligência) ou Adaga (+5 Agilidade)? (1,2 ou 3)");
Arma = int.Parse(Console.ReadLine());
if (Arma == 1)
{
    F = F + 5;
    
    Console.WriteLine("Você escolheu a Espada Longa, seus atributos agora são: ");
    Console.WriteLine("Força: " + F);
    Console.WriteLine("Agilidade: " + AG);
    Console.WriteLine("Inteligência: " + INT);
}
else if (Arma == 2)
{
    INT = INT + 5;

    Console.WriteLine("Você escolheu o Cajado, seus atributos agora são: ");
    Console.WriteLine("Força: " + F);
    Console.WriteLine("Agilidade: " + AG);
    Console.WriteLine("Inteligência: " + INT);
}
if (Arma == 3)
{
    AG = AG + 5;

    Console.WriteLine("Você escolheu a Adaga, seus atributos agora são: ");
    Console.WriteLine("Força: " + F);
    Console.WriteLine("Agilidade: " + AG);
    Console.WriteLine("Inteligência: " + INT);
}