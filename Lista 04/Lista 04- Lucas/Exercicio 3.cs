int f;
Console.WriteLine("O que voce deseja fazer?");
Console.WriteLine("Defender a floresta, Ajudar os mercadores ou Atacar os dois lados?(1, 2 ou 3)");
f = int.Parse(Console.ReadLine());
Console.WriteLine("Sua reputação com os Magos da floresta era de: 100");
Console.WriteLine("Sua reputação com os Mercadores era de : 110");

if (f == 1)
{
    Console.WriteLine("Sua reputação com os Magos da floresta aumentou em 50, e sua reputação com os Mercadores diminuiu em 30. Agora os Mercenarios declaram guerra contra você e seu clã.");
}
else if (f == 2)
{
    Console.WriteLine("Sua reputação com os Mercenarios aumentou em 50, e sua reputação com os Magos da floresta diminuiu em 30. Por conta de sua decisão, agora os Magos da floresta não disponibilizam mais materiais para seu clã.");
}
else if (f == 3)
{
    Console.WriteLine("Sua reputação com as duas facções é de 0, agora os dois lados te odeiam, e faram vingança a qualquer custo");
}
