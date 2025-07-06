
string palavraSecreta = "TESOURO";
string resposta;
char[] progresso = new char[7];
int tentativasRestantes = 10;
Console.WriteLine("Decodificador");

for (int i = 0; i < 10; i++)
{
    Console.WriteLine("De uma paltite de letra");
    resposta = Console.ReadLine();
    switch (resposta)
    {
        case "t":
            progresso[0] = 'T';
            break;
        case "e":
            progresso[1] = 'E';
            break;
        case "s":
            progresso[2] = 'S';
            break;
        case "o":
            progresso[3] = 'O';
            progresso[6] = 'O';
            break;
        case "u":
            progresso[4] = 'U';
            break;
        case "r":
            progresso[5] = 'R';
            break;

    }
    Console.WriteLine("Progressão:" + progresso[0] + " | " + progresso[1] + " | " + progresso[2] + " | " + progresso[3] + " | " + progresso[4] + " | " + progresso[5] + " | " + progresso[6] + " . ");
    if (progresso[0] == 'T' && progresso[1] == 'E' && progresso[2] == 'S' && progresso[3] == 'O' && progresso[4] == 'U' && progresso[5] == 'R' && progresso[6] == 'O')
    {
        Console.WriteLine("Parábens!Você acertou");
        i = 10;
    }
}
