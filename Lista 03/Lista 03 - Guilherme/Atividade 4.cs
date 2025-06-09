// See https://aka.ms/new-console-template for more information
int numero = 0;
Console.WriteLine("Qual seu nivel?");
numero = int.Parse(Console.ReadLine());

if (numero >= 5)
{
    Console.WriteLine("Você é forte o bastante para entrar nessa caverna!");
}

else if (numero <= 5)
{
    Console.WriteLine("Você ainda é fraco, vá treinar!");
}