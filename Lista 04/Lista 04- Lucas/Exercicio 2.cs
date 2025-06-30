string a, b, c;

Console.WriteLine("Você entra em uma sala escura, a sua vista estão 3 folhas, e nelas três enigmas diferentes");
Console.WriteLine("No primeiro enigma diz assim: O que é aquela coisa que pode lá e pelo menos você vê?");
a = Console.ReadLine();
Console.WriteLine("Falo todas as línguas, mas sempre respondo com a sua. Que são?");
b = Console.ReadLine();
Console.WriteLine("Frequentemente mergulha, mas raramente se molha.");
c = Console.ReadLine();

if (a == "O horizonte" & b != "Eco" & c != "Sol")
{
    Console.WriteLine("A armadilha está parcialmente desativada");
}
else if (b == "Eco" & c != "Sol" & a != "O horizonte")
{
    Console.WriteLine("A armadilha está parcialmente desativada");
}
else if (c == "Sol" & b != "Eco" & a != "O horizonte")
{
    Console.WriteLine("A armadilha está parcialmente desativada");
}
else if (a == "O horizonte" & b == "Eco" & c == "Sol")
{
    Console.WriteLine("A armadilha foi totalmente desativaada");
}
else
{
    Console.WriteLine("A armadilha não foi desativada");
}

