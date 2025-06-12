string a, b, c;

Console.WriteLine("Resgate do Grifo");
Console.WriteLine("Um grifo está preso em uma armadilha mágica.");
Console.WriteLine("Sua Perícia com Armadilhas é maior que 7? (sim/nao)");
a = Console.ReadLine();
Console.WriteLine("Você conhece o Feitiço de Dissipação Menor? (sim/nao)");
b = Console.ReadLine();
Console.WriteLine("Você possui um Cristal de Amplificação? (sim/nao)");
c = Console.ReadLine();
if (a == "Sim" && b == "Sim")
{
    Console.WriteLine("O grifo foi liberado");
}
else if (a == "Sim" && c == "Sim")
{
    Console.WriteLine("O grifo foi liberado");
}
else
{
    Console.WriteLine("O grifo continua preso");
}