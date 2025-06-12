int per = 5;
string fei = "sdasd";
string cris = "hhh";

Console.WriteLine("um grifo esta preso em uma armadilha");
Console.WriteLine("qual o seu nivel de pericia de armadilha?");
per = int.Parse(Console.ReadLine());

Console.WriteLine("voce conhece o feitiço de dissipação melhor?");
fei = Console.ReadLine();

Console.WriteLine("você possui o cirstal de amplificação?");
cris = Console.ReadLine();

if (per >= 7 && fei == "sim" || fei == "sim" && cris == "sim")
{
    Console.WriteLine("parabens voce libertou o grifo!");
}
else {
    Console.WriteLine("voce nao conseguiu liberar o grifo");
}
