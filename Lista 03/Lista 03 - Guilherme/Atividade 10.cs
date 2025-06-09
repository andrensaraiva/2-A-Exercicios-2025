// See https://aka.ms/new-console-template for more information
string pode = "pode";

string não = "não";

string cara = "cara";

Console.WriteLine("Um grifo esta preso em uma prisão magica e você precisa salva-lo");

Console.WriteLine("sua pericia com armadilhas é maior que 7? (sim/não)");
pode = Console.ReadLine();
if (pode == "sim" || pode == "não")
{
    Console.WriteLine("ok");
}

Console.WriteLine("Você conhece o feitiço de dissipação menor? (sim/não)");
não = Console.ReadLine();
if (não == "sim" || não == "não")
{
    Console.WriteLine("ok");
}

Console.WriteLine("Você possuir um Cristal de Amplificação? (sim/não)");
cara = Console.ReadLine();
if (cara == "sim" || cara == "não")
{
    Console.WriteLine("ok");
}
Console.WriteLine("Agora vamos ver se você consegue salvar o Grifo...");
if (pode == "sim" && não == "sim" || cara == "sim")
{
    Console.WriteLine("Você salva o Grifo");
}

else
{
    Console.WriteLine("Você não consegue salvar o Grifo");
}
