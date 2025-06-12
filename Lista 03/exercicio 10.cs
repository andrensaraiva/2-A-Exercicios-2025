using System.ComponentModel.Design;

string a;
string b;
string c;

Console.WriteLine("Um grifo está preso em uma armadilha mágica.");

Console.WriteLine("Sua Perícia com Armadilhas é maior que 7 ? (sim / nao)");
a = (Console.ReadLine());

Console.WriteLine("Você conhece o Feitiço de Dissipação Menor? (sim/nao)");
b = (Console.ReadLine());

Console.WriteLine("Você possui um Cristal de Amplificação? (sim/nao)");
c = (Console.ReadLine());

if (a == "sim" || b == "sim" && c == "sim")
{
    Console.WriteLine("Voce conseguiu libertar o grifo");
        
}
else
{
    Console.WriteLine("O grifo agora está preso por sua culpa");
}
