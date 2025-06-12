using System.ComponentModel.Design;

Console.WriteLine("Um grifo está preso em uma armadilha mágica.");

string PcA, FD, CA;

Console.WriteLine("Sua Perícia com Armadilhas é maior que 7?");
PcA = Console.ReadLine();
Console.WriteLine("Você conhece o Feitiço de Dissipação Menor?");
FD = Console.ReadLine();
Console.WriteLine("Você possui um Cristal de Amplificação?");
CA = Console.ReadLine();

if (PcA == "sim" & FD == "sim")
{
    Console.WriteLine("Voce libertou o grifo");
}
else if (FD == "sim" & CA == "sim")
{
    Console.WriteLine("Voce libertou o grifo");
}
else
{
    Console.WriteLine("Volte quando tiver os itens necessarios para libertar o grifo");
}