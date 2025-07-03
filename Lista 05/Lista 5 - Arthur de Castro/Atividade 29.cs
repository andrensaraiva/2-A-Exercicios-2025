
string palavraSecreta = "TESOURO";
string = resposta;
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
            char[0] = "T";
             break;
        case "e":
            char[1] = "E";
             break;
        case "s":
            char[1] = "S";
             break;
        case "o":
            char[1] = "O";
             break;
        case "u":
            char[1] = "U";
             break;
        case "r":
            char[1] = "R";
             break;
        case "o":
            char[1] = "O";
             break;
    }
    Console.WriteLine("Progressão:" + char[0] + "," + char[1] + "," + char{2] + "," + char[3] + "," + char[4] + "," + char[5] + "," + char[6] + ",");
}
