// 10. O Resgate do Grifo


Console.WriteLine("Um grifo está preso em uma armadilha mágica.");

string p, f, c;

Console.WriteLine("Sua Perícia com Armadilhas é maior que 7? (sim/nao)");
p = Console.ReadLine();
Console.WriteLine("Você conhece o Feitiço de Dissipação Menor? (sim/nao)");
f = Console.ReadLine();
Console.WriteLine("Você possui um Cristal de Amplificação? (sim/nao)");
c = Console.ReadLine();

if (p == "sim" & f == "sim")
{
    Console.WriteLine("O grifo é liberado!");
}
else if (f == "sim" & c == "sim")
{
    Console.WriteLine("O grifo foi liberado!");
}
else
{
    Console.WriteLine("O grifo continua preso.");
}

