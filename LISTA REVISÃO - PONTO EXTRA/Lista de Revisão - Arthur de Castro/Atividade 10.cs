string clima;
string montaria;

Console.WriteLine("Clima e Viagem");
Console.Write("Digite o clima (Ensolarado/Chuvoso/Nevando): ");
clima = Console.ReadLine();
Console.Write("Digite a montaria (Cavalo/Lobo/Nenhuma): ");
montaria = Console.ReadLine();

int tempo = 10;
if (clima == "chuvoso")
{
    tempo += 2;
}
else if (clima == "nevando")
{
    tempo += 5;
}
    if (montaria == "cavalo")
    {
        tempo -= 3;
    }
 else if (montaria == "lobo")
    {
        tempo -= 4;
    }

    Console.WriteLine("Tempo de viagem: " +  tempo + " horas");
