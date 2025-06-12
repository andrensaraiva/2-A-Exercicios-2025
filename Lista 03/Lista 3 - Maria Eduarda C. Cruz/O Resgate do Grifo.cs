// O Resgate do Grifo

string pericia = "";
string feitico = "";
string cristal = "";
Console.WriteLine("Sua pericia com armadilhas e maior que 7? (sim/nao)");
pericia = Console.ReadLine();
Console.WriteLine("Voce conhece o feitico de dissipacao menor? (sim/nao)");
feitico = Console.ReadLine();
Console.WriteLine("Voce possui um cristal de amplificacao? (sim/nao)");
cristal = Console.ReadLine();
if (pericia == "sim" && feitico == "sim" || feitico == "sim" && cristal == "sim")
{
    Console.WriteLine("O grifo foi liberto!");
}
else
{
    Console.WriteLine("O grifo continua preso...");
}
    
// Cenário: Um grifo está preso em uma armadilha mágica.
// Sua missão:
// Pergunte:

// "Sua Perícia com Armadilhas é maior que 7? (sim/nao)"

// "Você conhece o Feitiço de Dissipação Menor? (sim/nao)"

// "Você possui um Cristal de Amplificação? (sim/nao)"

// Condição de sucesso:

// Elara liberta o grifo se (perícia > 7 E conhece o feitiço) ou (conhece o feitiço E tem o cristal).
