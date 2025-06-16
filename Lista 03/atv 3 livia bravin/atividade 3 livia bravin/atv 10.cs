string pericia;
string feitico;
string cristal;

Console.WriteLine("Sua Perícia com Armadilhas é maior que 7? (sim/nao)");
pericia = Console.ReadLine();

Console.WriteLine("Você conhece o Feitiço de Dissipação Menor? (sim/nao)");
feitico = Console.ReadLine();

Console.WriteLine("Você possui um Cristal de Amplificação? (sim/nao)");
cristal = Console.ReadLine();

{
    if ((pericia == "sim" && feitico == "sim") || (feitico == "sim" && cristal == "sim"))
    {
        Console.WriteLine("Elara liberta o grifo");
    }
    else
    {
        Console.WriteLine("O grifo continua preso");
    }
}
