Console.WriteLine("Sua Perícia com Armadilhas é maior que 7? (sim/nao)");
string resposta1 = Console.ReadLine();

Console.WriteLine("Você conhece o Feitiço de Dissipação Menor? (sim/nao)");
string resposta2 = Console.ReadLine();

Console.WriteLine("Você possui um Cristal de Amplificação? (sim/nao)");
string resposta3 = Console.ReadLine();

if (resposta1 == "sim" && resposta2 == "sim" || resposta2 == "sim" && resposta3 == "sim")
{
    Console.WriteLine("Elara liberta o grifo");
}
else
{
    Console.WriteLine("Elara não liberta o grifo");
}

