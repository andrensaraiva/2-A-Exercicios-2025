Console.WriteLine("Qual o clima atual? (Ensolado, Chuvoso ou Nevando)");
string climaatual = Console.ReadLine();
Console.WriteLine("Qual montaria voce esta usando? (Cavalo, Lobo, Nenhuma)");
string montaria = Console.ReadLine();

int Tempo = 10;

if (climaatual == "Chuvoso")
{
    Tempo += 2;
}
else if (climaatual == "Nevando")
{
    Tempo += 5;
}
if (montaria == "Cavalo")
{
    Tempo -= 3;
}
else if (montaria == "Lobo")
{
    Tempo -= 4;
}
if (climaatual == "Nevando" && montaria == "Nenhuma")
{
    Tempo += 5;
}
Console.WriteLine(" ");
Console.WriteLine("O tempo que a viagem vai demorar sera aproximadamente: " +  Tempo + " horas.");