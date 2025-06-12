string pericia = "sim";

string não = "não";

string cristal = "ok";

Console.WriteLine("Um grifo esta preso em uma prisão magica e você precisa salva-lo");

Console.WriteLine("sua pericia com armadilhas é maior que 7? (sim/não)");
pericia = Console.ReadLine();
if (pericia == "sim" || pericia == "não")
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
cristal = Console.ReadLine();
if (cristal == "sim" || cristal == "não")
{
    Console.WriteLine("ok");
}
Console.WriteLine("Agora vamos ver se você consegue salvar o Grifo...");
if (pericia == "sim" && não == "sim" || cristal == "sim")
{
    Console.WriteLine("Você salva o Grifo");
}

else
{
    Console.WriteLine("Você não consegue salvar o Grifo");
}
